using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class WorkingStatus
    {
        public int IstihtamDurumId { get; set; }
        public string? IstihtamDurumu { get; set; }
        public byte? Durum { get; set; }
        public string? Aciklama { get; set; }
    }
}
