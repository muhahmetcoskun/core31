using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Tmsy
    {
        public int Tmsyid { get; set; }
        public string? Tmsydurumu { get; set; }
        public byte? Durum { get; set; }
    }
}
