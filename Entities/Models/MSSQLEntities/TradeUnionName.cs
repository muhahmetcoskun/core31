using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class TradeUnionName
    {
        public int SendikaAdId { get; set; }
        public string? SendikaAdi { get; set; }
        public byte? Durum { get; set; }
    }
}
