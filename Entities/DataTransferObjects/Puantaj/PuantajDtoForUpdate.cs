using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Puantaj
{
    public record PuantajDtoForUpdate : PuantajDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }
}
