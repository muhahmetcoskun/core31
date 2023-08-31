using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class WorkingType
    {
        public int IsdihtamSekliId { get; set; }
        public string? IsdihtamSekli { get; set; }
        public byte? Durum { get; set; }
    }
}
