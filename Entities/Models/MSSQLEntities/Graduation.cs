using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Graduation
    {
        public int PersonelEgitimId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public string? OkulTuru { get; set; }
        public string? FakulteLiseTur { get; set; }
        public string? TahsilDerece { get; set; }
        public string? Bolum { get; set; }
        public string? OkulAd { get; set; }
        public int? EgitimDurumId { get; set; }
        public byte? Durum { get; set; }
    }
}
