using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class KategoriTipiConfig : IEntityTypeConfiguration<KategoriTipi>
    {
        public void Configure(EntityTypeBuilder<KategoriTipi> builder)
        {
            builder.HasKey(c => c.Id); // PK
            builder.Property(c => c.Adi).IsRequired();

            builder.HasData(
                new KategoriTipi()
                {
                    Id = 1,
                    Adi = "Ücretli İzin"
                },
                new KategoriTipi()
                {
                    Id = 2,
                    Adi = "Ücretsiz İzin"
                },
                new KategoriTipi()
                {
                    Id = 3,
                    Adi = "Sağlık"
                },
                new KategoriTipi()
                {
                    Id = 4,
                    Adi = "Diğer"
                }
            );
        }
    }
}
