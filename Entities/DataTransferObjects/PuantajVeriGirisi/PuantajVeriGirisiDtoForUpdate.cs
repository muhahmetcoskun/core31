using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.PuantajVeriGirisi
{
    public record PuantajVeriGirisiDtoForUpdate : PuantajVeriGirisiDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }
}
