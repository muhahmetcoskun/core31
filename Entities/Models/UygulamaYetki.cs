using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class UygulamaYetki 
    {
        public int Id { get; set; } 

        // Ref: navigation property
        public int UygulamaId { get; set; }
        public Uygulama Uygulama { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Boolean Aktif { get; set; }
    }
}
