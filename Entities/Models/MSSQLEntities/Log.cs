using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Log
    {
        public int? Id { get; set; }
        public string? Islem { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Kullanici { get; set; }
        public string? KullaniciIp { get; set; }
        public string? Veriler { get; set; }
    }
}
