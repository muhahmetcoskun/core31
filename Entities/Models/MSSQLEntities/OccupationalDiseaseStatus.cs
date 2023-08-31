using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class OccupationalDiseaseStatus
    {
        public int? HastalikDurumId { get; set; }
        public string? HastalikDurumu { get; set; }
        public byte? Durum { get; set; }
    }
}
