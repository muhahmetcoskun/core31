using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repositories.EFCore
{
    public class RepositoryContext : IdentityDbContext<      
        User,
        Rol,
        int,
        IdentityUserClaim<int>,
        UserRole,
        IdentityUserLogin<int>,
        IdentityRoleClaim<int>, 
        IdentityUserToken<int>>
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) :
            base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PuantajVeriGirisi> PuantajVeriGirisies { get; set; }
        public DbSet<KategoriTipi> KategoriTipies { get; set; }
        public DbSet<Uygulama> Uygulamas { get; set; }
        public DbSet<UygulamaYetki> UygulamaYetkies { get; set; }
        public DbSet<Puantaj> Puantajs { get; set; }
        public DbSet<PuantajTuru> PuantajTurus { get; set; }
        public DbSet<PrimTuru> PrimTurus { get; set; }
        public DbSet<PersonelPrim> PersonelPrims { get; set; }
        public DbSet<ResmiTatil> ResmiTatils { get; set; }
        public DbSet<GunlukCalismaSuresi> GunlukCalismaSuresies { get; set; }
        public DbSet<CalismaGrubu> CalismaGrubus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("PGMBilgiSistemi");
            //modelBuilder.ApplyConfiguration(new BookConfig());
            //modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

    public class User<T>
    {
    }
}
