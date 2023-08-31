using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class PriceGrade
    {
        public int UcretDereceId { get; set; }
        public string? UcretDerecesi { get; set; }
        public byte? Durum { get; set; }
    }
}
