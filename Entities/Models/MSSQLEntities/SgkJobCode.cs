using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class SgkJobCode
    {
        public int SgkMeslekKodId { get; set; }
        public string? SgkMeslekKodu { get; set; }
        public string? SgkMeslekAdi { get; set; }
        public byte? Durum { get; set; }
    }
}
