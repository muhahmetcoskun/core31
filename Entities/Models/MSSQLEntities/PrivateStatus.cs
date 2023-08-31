using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class PrivateStatus
    {
        public int OzelDurumId { get; set; }
        public string? OzelDurumu { get; set; }
        public byte? Durum { get; set; }
    }
}
