using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class PermissionType
    {
        public int IzinTurId { get; set; }
        public string? IzinTuru { get; set; }
        public byte? Durum { get; set; }
    }
}
