using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class FamilyEducationStatus
    {
        public int? OgrenimId { get; set; }
        public string? OgrenimDurum { get; set; }
        public byte? Durum { get; set; }
    }
}
