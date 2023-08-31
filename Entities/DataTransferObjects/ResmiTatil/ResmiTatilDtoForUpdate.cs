using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.ResmiTatil
{
    public record ResmiTatilDtoForUpdate : ResmiTatilDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }
}
