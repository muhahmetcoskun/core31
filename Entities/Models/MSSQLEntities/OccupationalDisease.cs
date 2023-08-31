using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class OccupationalDisease
    {
        public int PersonelHastalikId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? HastalikDurumId { get; set; }
        public DateTime? HastalikTarih { get; set; }
        public string? HastalikAciklama { get; set; }
    }
}
