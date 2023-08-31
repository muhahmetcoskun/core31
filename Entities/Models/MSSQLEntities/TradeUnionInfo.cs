using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class TradeUnionInfo
    {
        public int SendikaBilgiId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? SendikaDurumId { get; set; }
        public int? SendikaAdId { get; set; }
        public byte? Durum { get; set; }
    }
}
