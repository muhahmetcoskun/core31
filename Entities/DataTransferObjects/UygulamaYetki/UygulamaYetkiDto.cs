using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.UygulamaYetki
{
    public record UygulamaYetkiDto
    {
        public int Id { get; init; }
        public int UygulamaId { get; init; }
        public int RolId { get; init; }
        public int UserId { get; init; }
        public Boolean Aktif { get; init; }

    }
}
