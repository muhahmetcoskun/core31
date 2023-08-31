using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class WorkplaceHeadquarter
    {
        public int GenelMudurlukId { get; set; }
        public string? GenelMudurluk { get; set; }
        public byte? Durum { get; set; }
    }
}
