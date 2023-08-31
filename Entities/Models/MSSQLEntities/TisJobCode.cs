using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class TisJobCode
    {
        public int TisMeslekKodId { get; set; }
        public string? TisMeslekKodu { get; set; }
        public string? TisMeslekAdi { get; set; }
        public byte? Durum { get; set; }
    }
}
