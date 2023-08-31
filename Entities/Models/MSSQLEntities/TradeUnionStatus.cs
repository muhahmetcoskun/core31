using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class TradeUnionStatus
    {
        public int SendikaDurumId { get; set; }
        public string? SendikaDurumu { get; set; }
        public byte? Durum { get; set; }
    }
}
