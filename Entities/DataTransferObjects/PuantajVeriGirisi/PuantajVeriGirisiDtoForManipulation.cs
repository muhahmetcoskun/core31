using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.PuantajVeriGirisi
{
    public abstract record PuantajVeriGirisiDtoForManipulation
    {
        [Required(ErrorMessage = "Veri Girişi zorunlu.")]
        public string VeriGirisi { get; init; }

        [Required(ErrorMessage = "Dayanak zorunlu.")]
        public string Dayanak { get; init; }

        [Required(ErrorMessage = "Simge zorunlu.")]
        public string Simge { get; init; }
        public Boolean Aktif { get; init; } = true;
    }
}
