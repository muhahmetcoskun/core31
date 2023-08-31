using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Promotion
    {
        public int PersonelTerfiId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? UcretDereceId { get; set; }
        public DateTime? TerfiTarihi { get; set; }
        public int? TerfiNedenId { get; set; }
        public string? Aciklama { get; set; }
        public byte? Durum { get; set; }
    }
}
