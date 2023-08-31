using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class FamilyWorkingStatus
    {
        public int? CalismaDurumId { get; set; }
        public string? CalismaDurum { get; set; }
        public byte? Durum { get; set; }
    }
}
