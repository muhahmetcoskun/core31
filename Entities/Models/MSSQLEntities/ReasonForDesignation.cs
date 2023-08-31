using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ReasonForDesignation
    {
        public string AtamaIstegiNedenId { get; set; } = null!;
        public string? AtamaIstegiNedeni { get; set; }
        public byte? Durum { get; set; }
    }
}
