using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class AdminStatus
    {
        public int IdarecilikDurumId { get; set; }
        public string? IdarecilikDurumu { get; set; }
        public byte? Durum { get; set; }
    }
}
