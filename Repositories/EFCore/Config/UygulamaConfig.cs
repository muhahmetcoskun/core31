using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class UygulamaConfig : IEntityTypeConfiguration<Uygulama>
    {
        public void Configure(EntityTypeBuilder<Uygulama> builder)
        {
            builder.HasKey(c => c.Id); // PK
            builder.Property(c => c.Adi).IsRequired();

            builder.HasData(
                new Uygulama()
                {
                    Id = 1,
                    Adi = "Puantaj"
                },
                new Uygulama()
                {
                    Id = 2,
                    Adi = "İşçi Bilgi"
                },
                new Uygulama()
                {
                    Id = 3,
                    Adi = "Test 1"
                },
                new Uygulama()
                {
                    Id = 4,
                    Adi = "Test 2"
                }
            );
        }
    }
}
