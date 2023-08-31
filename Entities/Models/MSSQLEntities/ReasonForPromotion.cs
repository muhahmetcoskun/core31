using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ReasonForPromotion
    {
        public int TerfiNedenId { get; set; }
        public string? TerfiNedeni { get; set; }
        public byte? Durum { get; set; }
    }
}
