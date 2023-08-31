using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class PriceType
    {
        public int UcretTurId { get; set; }
        public string? UcretTuru { get; set; }
        public byte? Durum { get; set; }
    }
}
