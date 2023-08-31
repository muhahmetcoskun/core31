using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PGMBilgiSistemi");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalismaGrubus",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonelId = table.Column<int>(type: "integer", nullable: false),
                    OOMesaiBaslamaSaati = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    OOMesaiBitisSaati = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    YemekMolasiBaslamaSaati = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    YemekMolasiBitisSaati = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    OSMesaiBaslamaSaati = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    OSMesaiBitisSaati = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    HaftalikCalismaSuresi = table.Column<int>(type: "integer", nullable: false),
                    HaftaTatiliGunu = table.Column<int>(type: "integer", nullable: false),
                    Aktif = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaGrubus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "GunlukCalismaSuresies",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SiraNo = table.Column<int>(type: "integer", nullable: false),
                    Adi = table.Column<string>(type: "text", nullable: false),
                    Aktif = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukCalismaSuresies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KategoriTipies",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriTipies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrimTurus",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SiraNo = table.Column<int>(type: "integer", nullable: false),
                    Adi = table.Column<string>(type: "text", nullable: false),
                    Aktif = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimTurus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Puantajs",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BaslangicDonem = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BitisDonem = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    KapamaTarihi = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puantajs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PuantajTurus",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuantajTurus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResmiTatils",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Aktif = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResmiTatils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uygulamas",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uygulamas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PuantajVeriGirisies",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VeriGirisi = table.Column<string>(type: "text", nullable: false),
                    Dayanak = table.Column<string>(type: "text", nullable: false),
                    Simge = table.Column<string>(type: "text", nullable: false),
                    Aktif = table.Column<bool>(type: "boolean", nullable: false),
                    KategoriTipiId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuantajVeriGirisies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PuantajVeriGirisies_KategoriTipies_KategoriTipiId",
                        column: x => x.KategoriTipiId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "KategoriTipies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelPrims",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PrimTuruId = table.Column<int>(type: "integer", nullable: false),
                    PersonelId = table.Column<int>(type: "integer", nullable: false),
                    Aktif = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelPrims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelPrims_PrimTurus_PrimTuruId",
                        column: x => x.PrimTuruId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "PrimTurus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UygulamaYetkies",
                schema: "PGMBilgiSistemi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UygulamaId = table.Column<int>(type: "integer", nullable: false),
                    RolId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Aktif = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UygulamaYetkies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UygulamaYetkies_AspNetRoles_RolId",
                        column: x => x.RolId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UygulamaYetkies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UygulamaYetkies_Uygulamas_UygulamaId",
                        column: x => x.UygulamaId,
                        principalSchema: "PGMBilgiSistemi",
                        principalTable: "Uygulamas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "PGMBilgiSistemi",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "c4b93d15-dafb-4254-a5ac-a5b545d38cb5", "User", "USER" },
                    { 2, "6d46c39a-b327-4f37-abb8-7a3234e4906f", "Editor", "EDITOR" },
                    { 3, "16051b02-627c-4cd9-9a55-ad3684f89f04", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "PGMBilgiSistemi",
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Computer Science" },
                    { 2, "Network" },
                    { 3, "Database Management Systems" }
                });

            migrationBuilder.InsertData(
                schema: "PGMBilgiSistemi",
                table: "KategoriTipies",
                columns: new[] { "Id", "Adi" },
                values: new object[,]
                {
                    { 1, "Ücretli İzin" },
                    { 2, "Ücretsiz İzin" },
                    { 3, "Sağlık" },
                    { 4, "Diğer" }
                });

            migrationBuilder.InsertData(
                schema: "PGMBilgiSistemi",
                table: "PuantajTurus",
                columns: new[] { "Id", "Adi" },
                values: new object[,]
                {
                    { 1, "Aylık Maaş Puantajı" },
                    { 2, "İptal Puantajı" },
                    { 3, "Ek Puantaj" },
                    { 4, "İlave Tediye Puantajı" },
                    { 5, "Akdi İkramiye Puantajı" },
                    { 6, "Ek Ödeme Puantajı" },
                    { 7, "Yıllık Ücretli İzin Puantajı" },
                    { 8, "Hastalık Yardımı Puantajı" },
                    { 9, "Tis Farkı Puantajı" }
                });

            migrationBuilder.InsertData(
                schema: "PGMBilgiSistemi",
                table: "Uygulamas",
                columns: new[] { "Id", "Adi" },
                values: new object[,]
                {
                    { 1, "Puantaj" },
                    { 2, "İşçi Bilgi" },
                    { 3, "Test 1" },
                    { 4, "Test 2" }
                });

            migrationBuilder.InsertData(
                schema: "PGMBilgiSistemi",
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, 75m, "Karagöz ve Hacivat" },
                    { 2, 2, 175m, "Mesnevi" },
                    { 3, 1, 375m, "Devlet" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "PGMBilgiSistemi",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "PGMBilgiSistemi",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "PGMBilgiSistemi",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "PGMBilgiSistemi",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "PGMBilgiSistemi",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "PGMBilgiSistemi",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "PGMBilgiSistemi",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                schema: "PGMBilgiSistemi",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukCalismaSuresies_SiraNo",
                schema: "PGMBilgiSistemi",
                table: "GunlukCalismaSuresies",
                column: "SiraNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonelPrims_PrimTuruId",
                schema: "PGMBilgiSistemi",
                table: "PersonelPrims",
                column: "PrimTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimTurus_SiraNo",
                schema: "PGMBilgiSistemi",
                table: "PrimTurus",
                column: "SiraNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PuantajVeriGirisies_KategoriTipiId",
                schema: "PGMBilgiSistemi",
                table: "PuantajVeriGirisies",
                column: "KategoriTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_UygulamaYetkies_RolId",
                schema: "PGMBilgiSistemi",
                table: "UygulamaYetkies",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_UygulamaYetkies_UserId",
                schema: "PGMBilgiSistemi",
                table: "UygulamaYetkies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UygulamaYetkies_UygulamaId",
                schema: "PGMBilgiSistemi",
                table: "UygulamaYetkies",
                column: "UygulamaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "Books",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "CalismaGrubus",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "GunlukCalismaSuresies",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "PersonelPrims",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "Puantajs",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "PuantajTurus",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "PuantajVeriGirisies",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "ResmiTatils",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "UygulamaYetkies",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "PrimTurus",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "KategoriTipies",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "PGMBilgiSistemi");

            migrationBuilder.DropTable(
                name: "Uygulamas",
                schema: "PGMBilgiSistemi");
        }
    }
}
