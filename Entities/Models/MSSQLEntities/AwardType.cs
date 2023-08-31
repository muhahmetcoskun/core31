using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class AwardType
    {
        public int OdulTakdirBilgiId { get; set; }
        public string? OdulTakdirBilgiKodu { get; set; }
        public string? OdulTakdirBilgi { get; set; }
        public byte? Durum { get; set; }
    }
}
