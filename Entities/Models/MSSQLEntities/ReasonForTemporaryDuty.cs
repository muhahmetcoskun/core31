using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ReasonForTemporaryDuty
    {
        public int GeciciGorevNedenId { get; set; }
        public string? GeciciGorevNedeni { get; set; }
        public byte? Durum { get; set; }
    }
}
