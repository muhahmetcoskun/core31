using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.ResmiTatil
{
    public abstract record ResmiTatilDtoForManipulation
    {
        [Required(ErrorMessage = "Tarih zorunludur.")]
        public DateTime Tarih { get; init; }

        public Boolean Aktif { get; init; } = true;
    }
}
