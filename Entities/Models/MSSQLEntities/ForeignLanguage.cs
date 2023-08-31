using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ForeignLanguage
    {
        public int YabanciDilBilgiId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? YabanciDilId { get; set; }
        public string? SinavAdi { get; set; }
        public string? Puani { get; set; }
        public DateTime? BelgeTarihi { get; set; }
        public byte? Durum { get; set; }
    }
}
