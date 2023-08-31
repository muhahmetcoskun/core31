using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.UygulamaYetki
{
    public record UygulamaYetkiDtoForUpdate : UygulamaYetkiDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }
}
