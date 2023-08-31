using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class PuantajTuruConfig : IEntityTypeConfiguration<PuantajTuru>
    {
        public void Configure(EntityTypeBuilder<PuantajTuru> builder)
        {
            builder.HasKey(c => c.Id); // PK
            builder.Property(c => c.Adi).IsRequired();

            builder.HasData(
                new PuantajTuru()
                {
                    Id = 1,
                    Adi = "Aylık Maaş Puantajı"
                },
                new PuantajTuru()
                {
                    Id = 2,
                    Adi = "İptal Puantajı"
                },
                new PuantajTuru()
                {
                    Id = 3,
                    Adi = "Ek Puantaj"
                },
                new PuantajTuru()
                {
                    Id = 4,
                    Adi = "İlave Tediye Puantajı"
                },
                new PuantajTuru()
                {
                    Id = 5,
                    Adi = "Akdi İkramiye Puantajı"
                },
                new PuantajTuru()
                {
                    Id = 6,
                    Adi = "Ek Ödeme Puantajı"
                },
                new PuantajTuru()
                {
                    Id = 7,
                    Adi = "Yıllık Ücretli İzin Puantajı"
                },
                new PuantajTuru()
                {
                    Id = 8,
                    Adi = "Hastalık Yardımı Puantajı"
                },
                new PuantajTuru()
                {
                    Id = 9,
                    Adi = "Tis Farkı Puantajı"
                }
            );
        }
    }
}
