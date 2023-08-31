using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.PuantajVeriGirisi
{
    public record PuantajVeriGirisiDtoForInsertion : PuantajVeriGirisiDtoForManipulation
    {
        public int Id { get; init; }

        [Required(ErrorMessage = "Kategori tipi zorunlu.")]
        public int KategoriTipiId { get; init; }
    }
}
