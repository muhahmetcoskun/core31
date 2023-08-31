using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ServiceInfo
    {
        public int ServisBilgiId { get; set; }
        public string? ServisBilgisi { get; set; }
        public byte? Durum { get; set; }
    }
}
