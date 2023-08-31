using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class CurrentStatus
    {
        public int MevcutStatuId { get; set; }
        public string? MevcutStatu { get; set; }
        public byte? Durum { get; set; }
    }
}
