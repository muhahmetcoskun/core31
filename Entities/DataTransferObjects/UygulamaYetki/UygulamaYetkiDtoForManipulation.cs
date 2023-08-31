using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.UygulamaYetki
{
    public abstract record UygulamaYetkiDtoForManipulation
    {
        [Required(ErrorMessage = "Uygulama zorunlu.")]
        public int UygulamaId { get; init; }

        [Required(ErrorMessage = "Rol zorunlu.")]
        public int RolId { get; init; }

        [Required(ErrorMessage = "Kullanıcı zorunlu.")]
        public int UserId { get; init; }

        public Boolean Aktif { get; init; } = true;
    }
}
