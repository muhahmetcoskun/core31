using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class DesignationApproval
    {
        public int OnayId { get; set; }
        public bool? OnayDurumu { get; set; }
        public string? OnayDurumValue { get; set; }
    }
}
