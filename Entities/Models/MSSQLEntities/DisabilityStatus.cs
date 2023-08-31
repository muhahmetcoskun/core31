using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class DisabilityStatus
    {
        public int EngelDurumId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? OzelDurumId { get; set; }
        public string? EngelDurumu { get; set; }
    }
}
