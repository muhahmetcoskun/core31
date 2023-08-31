using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class WorkingPrice
    {
        public int CalismaUcretBilgiId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? UcretTurId { get; set; }
        public int? GunlukCalismaSureId { get; set; }
        public int? UcretDereceId { get; set; }
        public int? UcretDerecesineTerfiId { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? SonUcretDerecesineYukselmeTarih { get; set; }
        public byte? Durum { get; set; }
    }
}
