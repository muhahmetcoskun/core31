using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class DailyWorkingTime
    {
        public int GunlukCalismaSureId { get; set; }
        public string? GunlukCalismaSuresi { get; set; }
        public byte? Durum { get; set; }
    }
}
