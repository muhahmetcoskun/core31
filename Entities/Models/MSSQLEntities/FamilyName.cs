using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class FamilyName
    {
        public int? YakinlikId { get; set; }
        public string? YakinlikAdi { get; set; }
        public byte? Durum { get; set; }
    }
}
