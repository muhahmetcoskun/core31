using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.UygulamaYetki
{
    public record UygulamaYetkiDtoForInsertion : UygulamaYetkiDtoForManipulation
    {
        public int Id { get; init; }
    }
}
