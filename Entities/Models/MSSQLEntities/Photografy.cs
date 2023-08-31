using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Photografy
    {
        public int PersonelFotografId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public byte[]? Fotograf { get; set; }
    }
}
