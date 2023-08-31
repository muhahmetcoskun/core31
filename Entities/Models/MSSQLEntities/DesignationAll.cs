using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class DesignationAll
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public DateTime? Tarih { get; set; }
        public byte? Durum { get; set; }
        public int? TabloKaydetDurum { get; set; }
        public int? BakanOnayDurumId { get; set; }
    }
}
