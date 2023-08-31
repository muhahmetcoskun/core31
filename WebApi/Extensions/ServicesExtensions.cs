using AspNetCoreRateLimit;
using Entities.DataTransferObjects.Book;
using Entities.DataTransferObjects.CalismaGrubu;
using Entities.DataTransferObjects.GunlukCalismaSuresi;
using Entities.DataTransferObjects.PersonelPrim;
using Entities.DataTransferObjects.PrimTuru;
using Entities.DataTransferObjects.Puantaj;
using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.DataTransferObjects.ResmiTatil;
using Entities.DataTransferObjects.UygulamaYetki;
using Entities.Models;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Presentation.ActionFilters;
using Presentation.Controllers;
using Repositories.Contracts;
using Repositories.EFCore;
using Services;
using Services.Contracts;
using System.Text;

namespace WebApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
            => services.AddDbContext<RepositoryContext>(options => options.UseNpgsql(configuration.GetConnectionString("sqlConnection")))
                       .AddDbContext<EmployeeContext>(options => options.UseSqlServer(configuration.GetConnectionString("MssqlConnection")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureMsSqlRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IMsSqlRepositoryManager, MsSqlRepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerService, LoggerManager>();

        public static void ConfigureActionFilters(this IServiceCollection services)
        {
            services.AddScoped<ValidationFilterAttribute>();
            services.AddSingleton<LogFilterAttribute>();
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("X-Pagination")
                );
            });
        }

        public static void ConfigureDataShaper(this IServiceCollection services)
        {
            services.AddScoped<IDataShaper<BookDto>, DataShaper<BookDto>>();
            services.AddScoped<IDataShaper<PuantajVeriGirisiDto>, DataShaper<PuantajVeriGirisiDto>>();
            services.AddScoped<IDataShaper<PuantajDto>, DataShaper<PuantajDto>>();
            services.AddScoped<IDataShaper<UygulamaYetkiDto>, DataShaper<UygulamaYetkiDto>>();
            services.AddScoped<IDataShaper<ResmiTatilDto>, DataShaper<ResmiTatilDto>>();
            services.AddScoped<IDataShaper<PrimTuruDto>, DataShaper<PrimTuruDto>>();
            services.AddScoped<IDataShaper<PersonelPrimDto>, DataShaper<PersonelPrimDto>>();
            services.AddScoped<IDataShaper<GunlukCalismaSuresiDto>, DataShaper<GunlukCalismaSuresiDto>>();
            services.AddScoped<IDataShaper<CalismaGrubuDto>, DataShaper<CalismaGrubuDto>>();
        }

        public static void ConfigureVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.ApiVersionReader = new HeaderApiVersionReader("api-version");

                opt.Conventions.Controller<BooksController>()
                    .HasApiVersion(new ApiVersion(1, 0));

                opt.Conventions.Controller<BooksV2Controller>()
                    .HasDeprecatedApiVersion(new ApiVersion(2, 0));

                opt.Conventions.Controller<PuantajVeriGirisiesController>()
                    .HasApiVersion(new ApiVersion(1, 0));

                opt.Conventions.Controller<PuantajsController>()
                    .HasApiVersion(new ApiVersion(1, 0));

                opt.Conventions.Controller<UygulamaYetkiesController>()
                    .HasApiVersion(new ApiVersion(1, 0));

                opt.Conventions.Controller<ResmiTatilsController>()
                    .HasApiVersion(new ApiVersion(1, 0));

                opt.Conventions.Controller<PrimTurusController>()
                 .HasApiVersion(new ApiVersion(1, 0)); 
                
                opt.Conventions.Controller<PersonelPrimsController>()
                 .HasApiVersion(new ApiVersion(1, 0)); 
                
                opt.Conventions.Controller<CalismaGrubusController>()
                 .HasApiVersion(new ApiVersion(1, 0));

                opt.Conventions.Controller<GunlukCalismaSuresiesController>()
       .HasApiVersion(new ApiVersion(1, 0));
            });
        }

        public static void ConfigureResponseCaching(this IServiceCollection services) =>
            services.AddResponseCaching();

        public static void ConfigureHttpCacheHeaders(this IServiceCollection services) =>
            services.AddHttpCacheHeaders(expirationOpt =>
            {
                expirationOpt.MaxAge = 90;
                expirationOpt.CacheLocation = CacheLocation.Public;
            },
            validationOpt =>
            {
                validationOpt.MustRevalidate = false;
            });

        public static void ConfigureRateLimitingOptions(this IServiceCollection services)
        {
            var rateLimitRules = new List<RateLimitRule>()
            {
                new RateLimitRule()
                {
                    Endpoint = "*",
                    Limit = 60,
                    Period = "1m"
                }
            };

            services.Configure<IpRateLimitOptions>(opt =>
            {
                opt.GeneralRules = rateLimitRules;
            });

            services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
            services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, Rol>(opts =>
            {
                opts.Password.RequireDigit = true;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequiredLength = 6;

                opts.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<RepositoryContext>()
                .AddDefaultTokenProviders();
        }

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings["secretKey"];

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings["validIssuer"],
                    ValidAudience = jwtSettings["validAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                }
            );
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Milli Savunma Bakanlığı",
                        Version = "v1",
                        Description = "Puantaj ASP.NET Core Web API",
                        TermsOfService = new Uri("https://www.msb.gov.tr/"),
                        Contact = new OpenApiContact
                        {
                            Name = "Yunus Emre ÇELİK",
                            Email = "yunus.emre.celik@msb.gov.tr",
                            Url = new Uri("https://www.msb.gov.tr/")
                        }
                    });

                s.SwaggerDoc("v2", new OpenApiInfo { Title = "Milli Savunma Bakanlığı", Version = "v2" });

                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    In = ParameterLocation.Header,
                    Description = "Place to add JWT with Bearer",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                s.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id="Bearer"
                            },
                            Name = "Bearer"
                        },
                        new List<string>()
                    }
                });
            });
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPuantajVeriGirisiRepository, PuantajVeriGirisiRepository>();
            services.AddScoped<IPuantajRepository, PuantajRepository>();
            services.AddScoped<IUygulamaYetkiRepository, UygulamaYetkiRepository>();
            services.AddScoped<IResmiTatilRepository, ResmiTatilRepository>();
            services.AddScoped<IPrimTuruRepository, PrimTuruRepository>();
            services.AddScoped<IPersonelPrimRepository, PersonelPrimRepository>();
            services.AddScoped<IGunlukCalismaSuresiRepository, GunlukCalismaSuresiRepository>();
            services.AddScoped<ICalismaGrubuRepository, CalismaGrubuRepository>();
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IPuantajVeriGirisiService, PuantajVeriGirisiManager>();
            services.AddScoped<IPuantajService, PuantajManager>();
            services.AddScoped<IUygulamaYetkiService, UygulamaYetkiManager>();
            services.AddScoped<IAuthenticationService, AuthenticationManager>();
            services.AddScoped<IResmiTatilService, ResmiTatilManager>();
            services.AddScoped<IPrimTuruService, PrimTuruManager>();
            services.AddScoped<IGunlukCalismaSuresiService, GunlukCalismaSuresiManager>();
            services.AddScoped<IPersonelPrimService, PersonelPrimManager>();
            services.AddScoped<ICalismaGrubuService, CalismaGrubuManager>();
        }

    }
}
