using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string? AdminAdi { get; set; }
        public string? AdminSoyadi { get; set; }
        public string? AdminUsername { get; set; }
        public string? AdminPassword { get; set; }
        public int? AdminRolId { get; set; }
        public bool? KullaniciDurumId { get; set; }
        public int? BirimId { get; set; }
        public int? SifreSıfırlanacakMi { get; set; }
    }
}
