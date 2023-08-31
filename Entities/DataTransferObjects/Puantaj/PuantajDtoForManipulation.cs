using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Puantaj
{
    public abstract record PuantajDtoForManipulation
    {
        [Required(ErrorMessage = "Başlangıç dönemi zorunlu.")]
        public DateTime BaslangicDonem { get; init; }
        [Required(ErrorMessage = "Bitiş dönemi zorunlu.")]
        public DateTime BitisDonem { get; init; }
        public DateTime KapamaTarihi { get; init; }
    }
}
