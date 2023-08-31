using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class CriminalName
    {
        public int VerilenCezaId { get; set; }
        public string? VerilenCeza { get; set; }
        public byte? Durum { get; set; }
    }
}
