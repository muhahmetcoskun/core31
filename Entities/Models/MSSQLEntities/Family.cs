using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Family
    {
        public int PersonelAileId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? YakinlikId { get; set; }
        public string? Adi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? DogumYeri { get; set; }
        public string? CalismaIsyeriAdi { get; set; }
        public string? OkulAdi { get; set; }
        public byte? Durum { get; set; }
        public int? CalismaDurumId { get; set; }
        public int? OgrenimId { get; set; }
    }
}
