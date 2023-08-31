using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ServicePlace
    {
        public int HizmetinGecYerId { get; set; }
        public string? HizmetinGecYer { get; set; }
        public byte? Durum { get; set; }
    }
}
