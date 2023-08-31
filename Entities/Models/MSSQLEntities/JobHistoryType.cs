using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class JobHistoryType
    {
        public int SafahatSekliId { get; set; }
        public string? SafahatSekli { get; set; }
        public byte? Durum { get; set; }
    }
}
