using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class GraduationStatus
    {
        public int EgitimDurumId { get; set; }
        public string? EgitimDurumu { get; set; }
        public byte? Durum { get; set; }
    }
}
