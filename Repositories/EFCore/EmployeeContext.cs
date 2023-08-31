using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Entities.Models.MSSQLEntities;

namespace Repositories.EFCore
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adaptation> Adaptations { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<AdminRole> AdminRoles { get; set; } = null!;
        public virtual DbSet<AdminStatus> AdminStatuses { get; set; } = null!;
        public virtual DbSet<Announcement> Announcements { get; set; } = null!;
        public virtual DbSet<Award> Awards { get; set; } = null!;
        public virtual DbSet<AwardType> AwardTypes { get; set; } = null!;
        public virtual DbSet<BirthCertificate> BirthCertificates { get; set; } = null!;
        public virtual DbSet<BloodGroup> BloodGroups { get; set; } = null!;
        public virtual DbSet<Communication> Communications { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseForm> CourseForms { get; set; } = null!;
        public virtual DbSet<CourseType> CourseTypes { get; set; } = null!;
        public virtual DbSet<Criminal> Criminals { get; set; } = null!;
        public virtual DbSet<CriminalName> CriminalNames { get; set; } = null!;
        public virtual DbSet<CurrentStatus> CurrentStatuses { get; set; } = null!;
        public virtual DbSet<DailyWorkingTime> DailyWorkingTimes { get; set; } = null!;
        public virtual DbSet<Designation> Designations { get; set; } = null!;
        public virtual DbSet<DesignationAll> DesignationAlls { get; set; } = null!;
        public virtual DbSet<DesignationApproval> DesignationApprovals { get; set; } = null!;
        public virtual DbSet<DesignationNews> DesignationNews { get; set; } = null!;
        public virtual DbSet<DesignationStatus> DesignationStatuses { get; set; } = null!;
        public virtual DbSet<DesignationStore> DesignationStores { get; set; } = null!;
        public virtual DbSet<DisabilityStatus> DisabilityStatuses { get; set; } = null!;
        public virtual DbSet<EvaluationCod> EvaluationCods { get; set; } = null!;
        public virtual DbSet<Family> Families { get; set; } = null!;
        public virtual DbSet<FamilyDiedStatus> FamilyDiedStatuses { get; set; } = null!;
        public virtual DbSet<FamilyEducationStatus> FamilyEducationStatuses { get; set; } = null!;
        public virtual DbSet<FamilyName> FamilyNames { get; set; } = null!;
        public virtual DbSet<FamilyWorkingStatus> FamilyWorkingStatuses { get; set; } = null!;
        public virtual DbSet<ForeignLanguage> ForeignLanguages { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Graduation> Graduations { get; set; } = null!;
        public virtual DbSet<GraduationStatus> GraduationStatuses { get; set; } = null!;
        public virtual DbSet<Identity> Identities { get; set; } = null!;
        public virtual DbSet<Isyeri> Isyeris { get; set; } = null!;
        public virtual DbSet<JobHistory> JobHistories { get; set; } = null!;
        public virtual DbSet<JobHistoryType> JobHistoryTypes { get; set; } = null!;
        public virtual DbSet<LanguageName> LanguageNames { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; } = null!;
        public virtual DbSet<Military> Militaries { get; set; } = null!;
        public virtual DbSet<MilitaryStatus> MilitaryStatuses { get; set; } = null!;
        public virtual DbSet<ModulCod> ModulCods { get; set; } = null!;
        public virtual DbSet<OccupationalDisease> OccupationalDiseases { get; set; } = null!;
        public virtual DbSet<OccupationalDiseaseStatus> OccupationalDiseaseStatuses { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<PermissionType> PermissionTypes { get; set; } = null!;
        public virtual DbSet<Personel> Personels { get; set; } = null!;
        public virtual DbSet<Photografy> Photografies { get; set; } = null!;
        public virtual DbSet<PriceGrade> PriceGrades { get; set; } = null!;
        public virtual DbSet<PriceGradeRise> PriceGradeRises { get; set; } = null!;
        public virtual DbSet<PriceType> PriceTypes { get; set; } = null!;
        public virtual DbSet<PrivateStatus> PrivateStatuses { get; set; } = null!;
        public virtual DbSet<Promotion> Promotions { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<ReasonForCriminal> ReasonForCriminals { get; set; } = null!;
        public virtual DbSet<ReasonForDesignation> ReasonForDesignations { get; set; } = null!;
        public virtual DbSet<ReasonForJobHistory> ReasonForJobHistories { get; set; } = null!;
        public virtual DbSet<ReasonForPermission> ReasonForPermissions { get; set; } = null!;
        public virtual DbSet<ReasonForPromotion> ReasonForPromotions { get; set; } = null!;
        public virtual DbSet<ReasonForTemporaryDuty> ReasonForTemporaryDuties { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<ServiceInfo> ServiceInfoes { get; set; } = null!;
        public virtual DbSet<ServicePlace> ServicePlaces { get; set; } = null!;
        public virtual DbSet<SgkJobCode> SgkJobCodes { get; set; } = null!;
        public virtual DbSet<ShiftInfo> ShiftInfoes { get; set; } = null!;
        public virtual DbSet<TemporaryDuty> TemporaryDuties { get; set; } = null!;
        public virtual DbSet<TisJobCode> TisJobCodes { get; set; } = null!;
        public virtual DbSet<Tmsy> Tmsies { get; set; } = null!;
        public virtual DbSet<TradeUnionInfo> TradeUnionInfoes { get; set; } = null!;
        public virtual DbSet<TradeUnionName> TradeUnionNames { get; set; } = null!;
        public virtual DbSet<TradeUnionStatus> TradeUnionStatuses { get; set; } = null!;
        public virtual DbSet<UserStatus> UserStatuses { get; set; } = null!;
        public virtual DbSet<WorkingPrice> WorkingPrices { get; set; } = null!;
        public virtual DbSet<WorkingStatus> WorkingStatuses { get; set; } = null!;
        public virtual DbSet<WorkingType> WorkingTypes { get; set; } = null!;
        public virtual DbSet<Workplace> Workplaces { get; set; } = null!;
        public virtual DbSet<WorkplaceHeadquarter> WorkplaceHeadquarters { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adaptation>(entity =>
            {
                entity.HasKey(e => e.PersonelIntibakId);

                entity.Property(e => e.BaslamaTarihi).HasColumnType("date");

                entity.Property(e => e.BitisTarihi).HasColumnType("date");

                entity.Property(e => e.HizmetinGecKurum).HasMaxLength(255);

                entity.Property(e => e.PrimGunSayisi).HasMaxLength(25);
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.AdminAdi).HasMaxLength(50);

                entity.Property(e => e.AdminPassword).HasMaxLength(50);

                entity.Property(e => e.AdminSoyadi).HasMaxLength(50);

                entity.Property(e => e.AdminUsername)
                    .HasMaxLength(12)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AdminRole>(entity =>
            {
                entity.HasKey(e => e.AdminRolId);

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.AdminRol)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AdminStatus>(entity =>
            {
                entity.HasKey(e => e.IdarecilikDurumId);

                entity.ToTable("AdminStatus");

                entity.Property(e => e.IdarecilikDurumu).HasMaxLength(55);
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Tarih).HasColumnType("date");
            });

            modelBuilder.Entity<Award>(entity =>
            {
                entity.HasKey(e => e.PersonelOdulId);

                entity.Property(e => e.OdulVerenAmirAdi).HasMaxLength(55);

                entity.Property(e => e.OdulVerenAmirRutbe).HasMaxLength(155);

                entity.Property(e => e.OdulVerenAmirSoyadi).HasMaxLength(55);

                entity.Property(e => e.VerildigiTarih).HasColumnType("date");
            });

            modelBuilder.Entity<AwardType>(entity =>
            {
                entity.HasKey(e => e.OdulTakdirBilgiId);

                entity.Property(e => e.OdulTakdirBilgi).HasMaxLength(255);

                entity.Property(e => e.OdulTakdirBilgiKodu).HasMaxLength(50);
            });

            modelBuilder.Entity<BirthCertificate>(entity =>
            {
                entity.HasKey(e => e.PersonelNufusId);

                entity.Property(e => e.AileSiraNo).HasMaxLength(55);

                entity.Property(e => e.CiltNo).HasMaxLength(55);

                entity.Property(e => e.Il).HasMaxLength(155);

                entity.Property(e => e.Ilce).HasMaxLength(155);

                entity.Property(e => e.MahalleKoy).HasMaxLength(155);

                entity.Property(e => e.SeriNo).HasMaxLength(55);

                entity.Property(e => e.SiraNo).HasMaxLength(55);
            });

            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.HasKey(e => e.KanGrupId);

                entity.Property(e => e.KanGrubu).HasMaxLength(25);
            });

            modelBuilder.Entity<Communication>(entity =>
            {
                entity.HasKey(e => e.PersonelIletisimId);

                entity.Property(e => e.Adres)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.CepTel).HasMaxLength(50);

                entity.Property(e => e.Ilce)
                    .HasMaxLength(55)
                    .IsFixedLength();

                entity.Property(e => e.Tafics)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.PersonelKursId);

                entity.Property(e => e.BaslamaTarihi).HasColumnType("date");

                entity.Property(e => e.BitisTarihi).HasColumnType("date");

                entity.Property(e => e.Konusu).HasMaxLength(255);

                entity.Property(e => e.KursSinavAdi).HasMaxLength(255);
            });

            modelBuilder.Entity<CourseForm>(entity =>
            {
                entity.HasKey(e => e.KursSekliId);

                entity.Property(e => e.KursSekli).HasMaxLength(25);
            });

            modelBuilder.Entity<CourseType>(entity =>
            {
                entity.HasKey(e => e.KursTuruId);

                entity.Property(e => e.KursTuru).HasMaxLength(155);

                entity.Property(e => e.KursTuruKodu).HasMaxLength(20);
            });

            modelBuilder.Entity<Criminal>(entity =>
            {
                entity.HasKey(e => e.PersonelCezaId);

                entity.Property(e => e.CezaTarihi).HasColumnType("date");

                entity.Property(e => e.CezaVerenAmir).HasMaxLength(155);

                entity.Property(e => e.CezayiVerenKisiAdi).HasMaxLength(155);

                entity.Property(e => e.SucTarihi).HasColumnType("date");
            });

            modelBuilder.Entity<CriminalName>(entity =>
            {
                entity.HasKey(e => e.VerilenCezaId);

                entity.Property(e => e.Durum).HasDefaultValueSql("((1))");

                entity.Property(e => e.VerilenCeza).HasMaxLength(155);
            });

            modelBuilder.Entity<CurrentStatus>(entity =>
            {
                entity.HasKey(e => e.MevcutStatuId);

                entity.ToTable("CurrentStatus");

                entity.Property(e => e.MevcutStatu).HasMaxLength(25);
            });

            modelBuilder.Entity<DailyWorkingTime>(entity =>
            {
                entity.HasKey(e => e.GunlukCalismaSureId);

                entity.Property(e => e.GunlukCalismaSuresi).HasMaxLength(25);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasKey(e => e.PersonelAtamaId);

                entity.Property(e => e.AyrilisTarihi).HasColumnType("date");

                entity.Property(e => e.IsyeriId).HasMaxLength(100);

                entity.Property(e => e.KatilisTarihi).HasColumnType("date");

                entity.Property(e => e.NakilTalepTarihi).HasColumnType("date");
            });

            modelBuilder.Entity<DesignationAll>(entity =>
            {
                entity.Property(e => e.Adi)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tarih).HasColumnType("date");
            });

            modelBuilder.Entity<DesignationApproval>(entity =>
            {
                entity.HasKey(e => e.OnayId);

                entity.Property(e => e.OnayId).ValueGeneratedNever();

                entity.Property(e => e.OnayDurumValue).HasMaxLength(25);
            });

            modelBuilder.Entity<DesignationNews>(entity =>
            {
                entity.HasKey(e => e.PersonelAtamaId);

                entity.Property(e => e.AmirOnayTarihi).HasColumnType("date");

                entity.Property(e => e.AtamaIstegiNedenId).HasMaxLength(100);

                entity.Property(e => e.AyrilisTarihi).HasColumnType("date");

                entity.Property(e => e.GmonayTarihi)
                    .HasColumnType("date")
                    .HasColumnName("GMOnayTarihi");

                entity.Property(e => e.GmudurAciklama).HasColumnName("GMudurAciklama");

                entity.Property(e => e.IsVerenOnayTarihi).HasColumnType("date");

                entity.Property(e => e.IsyeriId).HasMaxLength(100);

                entity.Property(e => e.KatilisTarihi).HasColumnType("date");

                entity.Property(e => e.MevcutIsyeriId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NakilTalepTarihi).HasColumnType("date");

                entity.Property(e => e.Pgmaciklama).HasColumnName("PGMAciklama");

                entity.Property(e => e.PgmonayTarihi)
                    .HasColumnType("date")
                    .HasColumnName("PGMOnayTarihi");
            });

            modelBuilder.Entity<DesignationStatus>(entity =>
            {
                entity.HasKey(e => e.NakilDurumId);

                entity.ToTable("DesignationStatus");

                entity.Property(e => e.NakilDurumId).ValueGeneratedNever();

                entity.Property(e => e.NakilDurumu).HasMaxLength(25);
            });

            modelBuilder.Entity<DesignationStore>(entity =>
            {
                entity.HasKey(e => e.PersonelHavuzId);

                entity.Property(e => e.AyrilisTarih).HasColumnType("date");

                entity.Property(e => e.IsyeriId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.KatilisTarih).HasColumnType("date");
            });

            modelBuilder.Entity<DisabilityStatus>(entity =>
            {
                entity.HasKey(e => e.EngelDurumId);

                entity.ToTable("DisabilityStatus");

                entity.Property(e => e.EngelDurumu).HasMaxLength(255);
            });

            modelBuilder.Entity<EvaluationCod>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DegerlendirmeId).HasColumnName("DegerlendirmeID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.HasKey(e => e.PersonelAileId);

                entity.Property(e => e.Adi)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.DogumYeri)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FamilyDiedStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FamilyDiedStatus");

                entity.Property(e => e.VefatDurumu).HasMaxLength(50);
            });

            modelBuilder.Entity<FamilyEducationStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FamilyEducationStatus");

                entity.Property(e => e.OgrenimDurum).HasMaxLength(50);
            });

            modelBuilder.Entity<FamilyName>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.YakinlikAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<FamilyWorkingStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FamilyWorkingStatus");

                entity.Property(e => e.CalismaDurum).HasMaxLength(50);
            });

            modelBuilder.Entity<ForeignLanguage>(entity =>
            {
                entity.HasKey(e => e.YabanciDilBilgiId);

                entity.Property(e => e.BelgeTarihi).HasColumnType("date");

                entity.Property(e => e.Puani).HasMaxLength(25);

                entity.Property(e => e.SinavAdi).HasMaxLength(155);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.CinsiyetId);

                entity.Property(e => e.Cinsiyeti).HasMaxLength(15);
            });

            modelBuilder.Entity<Graduation>(entity =>
            {
                entity.HasKey(e => e.PersonelEgitimId);

                entity.Property(e => e.Bolum).HasMaxLength(255);

                entity.Property(e => e.FakulteLiseTur).HasMaxLength(255);

                entity.Property(e => e.OkulAd).HasMaxLength(255);

                entity.Property(e => e.OkulTuru).HasMaxLength(255);

                entity.Property(e => e.TahsilDerece).HasMaxLength(55);
            });

            modelBuilder.Entity<GraduationStatus>(entity =>
            {
                entity.HasKey(e => e.EgitimDurumId);

                entity.ToTable("GraduationStatus");

                entity.Property(e => e.EgitimDurumu).HasMaxLength(155);
            });

            modelBuilder.Entity<Identity>(entity =>
            {
                entity.HasKey(e => e.PersonelKimlikId);

                entity.Property(e => e.Adi).HasMaxLength(100);

                entity.Property(e => e.AnaAdi).HasMaxLength(100);

                entity.Property(e => e.BabaAdi).HasMaxLength(100);

                entity.Property(e => e.CocukSayisi).HasMaxLength(3);

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.DogumYeri).HasMaxLength(100);

                entity.Property(e => e.IstihdamAciklama)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IstihdamAyrilisTarih).HasColumnType("date");

                entity.Property(e => e.KizlikSoyadi).HasMaxLength(100);

                entity.Property(e => e.MsbKatilisTarih).HasColumnType("date");

                entity.Property(e => e.SgkgirisTarihi)
                    .HasColumnType("date")
                    .HasColumnName("SGKGirisTarihi");

                entity.Property(e => e.SosyalGüvenlikNo).HasMaxLength(50);

                entity.Property(e => e.Soyadi).HasMaxLength(100);

                entity.Property(e => e.TcKimlikNo).HasMaxLength(11);

                entity.Property(e => e.Tmsyid).HasColumnName("TMSYId");
            });

            modelBuilder.Entity<Isyeri>(entity =>
            {
                entity.ToTable("Isyeri");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adi)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobHistory>(entity =>
            {
                entity.HasKey(e => e.PersonelSafahatId)
                    .HasName("PK_JobHistorys");

                entity.Property(e => e.AyrilisTarihi).HasColumnType("date");

                entity.Property(e => e.KatilisTarihi).HasColumnType("date");

                entity.Property(e => e.OnayTarihi).HasColumnType("date");
            });

            modelBuilder.Entity<JobHistoryType>(entity =>
            {
                entity.HasKey(e => e.SafahatSekliId);

                entity.Property(e => e.SafahatSekli).HasMaxLength(50);
            });

            modelBuilder.Entity<LanguageName>(entity =>
            {
                entity.HasKey(e => e.YabanciDilId);

                entity.Property(e => e.YabanciDil).HasMaxLength(55);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Islem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kullanici)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KullaniciIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KullaniciIP");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.Veriler).IsUnicode(false);
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.HasKey(e => e.MedeniHalId);

                entity.ToTable("MaritalStatus");

                entity.Property(e => e.MedeniHali).HasMaxLength(25);
            });

            modelBuilder.Entity<Military>(entity =>
            {
                entity.HasKey(e => e.PersonelAskerlikId);

                entity.Property(e => e.AskerlikBasTarih).HasColumnType("date");

                entity.Property(e => e.AskerlikSonrasiIseBaslamaTarih).HasColumnType("date");

                entity.Property(e => e.BorclanmaDurumu).HasMaxLength(55);

                entity.Property(e => e.HizmetSuresi).HasMaxLength(100);

                entity.Property(e => e.Statu).HasMaxLength(155);

                entity.Property(e => e.TerhisTarih).HasColumnType("date");
            });

            modelBuilder.Entity<MilitaryStatus>(entity =>
            {
                entity.HasKey(e => e.AskerlikDurumId);

                entity.ToTable("MilitaryStatus");

                entity.Property(e => e.AskerlikDurumu).HasMaxLength(25);
            });

            modelBuilder.Entity<ModulCod>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModulId).HasColumnName("ModulID");

                entity.Property(e => e.ModulName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OccupationalDisease>(entity =>
            {
                entity.HasKey(e => e.PersonelHastalikId);

                entity.Property(e => e.HastalikTarih).HasColumnType("date");
            });

            modelBuilder.Entity<OccupationalDiseaseStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OccupationalDiseaseStatus");

                entity.Property(e => e.HastalikDurumu).HasMaxLength(50);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.PersonelIzinId);

                entity.Property(e => e.BaslamaSaat).HasMaxLength(50);

                entity.Property(e => e.BaslamaTarihi).HasColumnType("date");

                entity.Property(e => e.BitisSaat).HasMaxLength(50);

                entity.Property(e => e.BitisTarihi).HasColumnType("date");
            });

            modelBuilder.Entity<PermissionType>(entity =>
            {
                entity.HasKey(e => e.IzinTurId);

                entity.Property(e => e.IzinTuru).HasMaxLength(55);
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Personel");

                entity.Property(e => e.Tckn)
                    .HasMaxLength(11)
                    .HasColumnName("TCKN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Photografy>(entity =>
            {
                entity.HasKey(e => e.PersonelFotografId);

                entity.Property(e => e.Fotograf).HasColumnType("image");
            });

            modelBuilder.Entity<PriceGrade>(entity =>
            {
                entity.HasKey(e => e.UcretDereceId);

                entity.Property(e => e.UcretDerecesi).HasMaxLength(15);
            });

            modelBuilder.Entity<PriceGradeRise>(entity =>
            {
                entity.HasKey(e => e.UcretDerecesineTerfiId);

                entity.Property(e => e.UcretDerecesineTerfiNedeni).HasMaxLength(155);
            });

            modelBuilder.Entity<PriceType>(entity =>
            {
                entity.HasKey(e => e.UcretTurId);

                entity.Property(e => e.UcretTuru).HasMaxLength(155);
            });

            modelBuilder.Entity<PrivateStatus>(entity =>
            {
                entity.HasKey(e => e.OzelDurumId)
                    .HasName("PK_PrivaEmployeeatus");

                entity.ToTable("PrivateStatus");

                entity.Property(e => e.OzelDurumu).HasMaxLength(255);
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasKey(e => e.PersonelTerfiId);

                entity.Property(e => e.Aciklama).HasMaxLength(255);

                entity.Property(e => e.TerfiTarihi).HasColumnType("date");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.IlId);

                entity.Property(e => e.IlAdi).HasMaxLength(55);
            });

            modelBuilder.Entity<ReasonForCriminal>(entity =>
            {
                entity.HasKey(e => e.CezaNedenId);

                entity.Property(e => e.CezaNedeni).HasMaxLength(255);
            });

            modelBuilder.Entity<ReasonForDesignation>(entity =>
            {
                entity.HasKey(e => e.AtamaIstegiNedenId);

                entity.Property(e => e.AtamaIstegiNedenId).HasMaxLength(55);

                entity.Property(e => e.AtamaIstegiNedeni).HasMaxLength(55);
            });

            modelBuilder.Entity<ReasonForJobHistory>(entity =>
            {
                entity.HasKey(e => e.SafahatGerekceId);

                entity.Property(e => e.SafahatGerekcesi).HasMaxLength(250);
            });

            modelBuilder.Entity<ReasonForPermission>(entity =>
            {
                entity.HasKey(e => e.IzinNedenId);

                entity.Property(e => e.IzinNedeni).HasMaxLength(200);
            });

            modelBuilder.Entity<ReasonForPromotion>(entity =>
            {
                entity.HasKey(e => e.TerfiNedenId);

                entity.Property(e => e.TerfiNedeni).HasMaxLength(155);
            });

            modelBuilder.Entity<ReasonForTemporaryDuty>(entity =>
            {
                entity.HasKey(e => e.GeciciGorevNedenId);

                entity.Property(e => e.GeciciGorevNedeni).HasMaxLength(55);
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CevapTarih).HasColumnType("date");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IstekTarih).HasColumnType("date");
            });

            modelBuilder.Entity<ServiceInfo>(entity =>
            {
                entity.HasKey(e => e.ServisBilgiId);

                entity.Property(e => e.ServisBilgisi).HasMaxLength(55);
            });

            modelBuilder.Entity<ServicePlace>(entity =>
            {
                entity.HasKey(e => e.HizmetinGecYerId);

                entity.Property(e => e.HizmetinGecYer).HasMaxLength(55);
            });

            modelBuilder.Entity<SgkJobCode>(entity =>
            {
                entity.HasKey(e => e.SgkMeslekKodId);

                entity.Property(e => e.SgkMeslekAdi).HasMaxLength(200);

                entity.Property(e => e.SgkMeslekKodu).HasMaxLength(10);
            });

            modelBuilder.Entity<ShiftInfo>(entity =>
            {
                entity.HasKey(e => e.VardiyaBilgiId);

                entity.Property(e => e.VardiyaBilgisi).HasMaxLength(25);
            });

            modelBuilder.Entity<TemporaryDuty>(entity =>
            {
                entity.HasKey(e => e.PersonelGeciciGorevId);

                entity.Property(e => e.BaslamaTarihi).HasColumnType("date");

                entity.Property(e => e.BitisTarihi).HasColumnType("date");
            });

            modelBuilder.Entity<TisJobCode>(entity =>
            {
                entity.HasKey(e => e.TisMeslekKodId);

                entity.Property(e => e.TisMeslekAdi).HasMaxLength(200);

                entity.Property(e => e.TisMeslekKodu).HasMaxLength(15);
            });

            modelBuilder.Entity<Tmsy>(entity =>
            {
                entity.ToTable("TMSies");

                entity.Property(e => e.Tmsyid).HasColumnName("TMSYId");

                entity.Property(e => e.Tmsydurumu)
                    .HasMaxLength(10)
                    .HasColumnName("TMSYDurumu")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TradeUnionInfo>(entity =>
            {
                entity.HasKey(e => e.SendikaBilgiId);
            });

            modelBuilder.Entity<TradeUnionName>(entity =>
            {
                entity.HasKey(e => e.SendikaAdId);

                entity.Property(e => e.SendikaAdi).HasMaxLength(55);
            });

            modelBuilder.Entity<TradeUnionStatus>(entity =>
            {
                entity.HasKey(e => e.SendikaDurumId);

                entity.ToTable("TradeUnionStatus");

                entity.Property(e => e.SendikaDurumu).HasMaxLength(55);
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.HasKey(e => e.KullaniciDurumId);

                entity.ToTable("UserStatus");

                entity.Property(e => e.KullaniciDurumu).HasMaxLength(10);
            });

            modelBuilder.Entity<WorkingPrice>(entity =>
            {
                entity.HasKey(e => e.CalismaUcretBilgiId);

                entity.Property(e => e.Aciklama).HasMaxLength(255);

                entity.Property(e => e.SonUcretDerecesineYukselmeTarih).HasColumnType("date");
            });

            modelBuilder.Entity<WorkingStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkingStatus");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IstihtamDurumId).ValueGeneratedOnAdd();

                entity.Property(e => e.IstihtamDurumu).IsUnicode(false);
            });

            modelBuilder.Entity<WorkingType>(entity =>
            {
                entity.HasKey(e => e.IsdihtamSekliId);

                entity.Property(e => e.IsdihtamSekli)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Workplace>(entity =>
            {
                entity.HasKey(e => e.IsyeriId);

                entity.Property(e => e.Birimi).HasMaxLength(10);

                entity.Property(e => e.Il).HasMaxLength(25);

                entity.Property(e => e.IsYeriAdi).HasMaxLength(100);

                entity.Property(e => e.Kuvvet).HasMaxLength(10);
            });

            modelBuilder.Entity<WorkplaceHeadquarter>(entity =>
            {
                entity.HasKey(e => e.GenelMudurlukId);

                entity.Property(e => e.GenelMudurluk).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
