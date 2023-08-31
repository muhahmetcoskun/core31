using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ReasonForPermission
    {
        public int IzinNedenId { get; set; }
        public string? IzinNedeni { get; set; }
        public byte? Durum { get; set; }
    }
}
