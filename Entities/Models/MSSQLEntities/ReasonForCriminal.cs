using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ReasonForCriminal
    {
        public int CezaNedenId { get; set; }
        public string? CezaNedeni { get; set; }
        public byte? Durum { get; set; }
    }
}
