using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Workplace
    {
        public int IsyeriId { get; set; }
        public int? GenelMudurlukId { get; set; }
        public string? IsYeriAdi { get; set; }
        public string? Kuvvet { get; set; }
        public string? Birimi { get; set; }
        public string? Il { get; set; }
        public byte? Durum { get; set; }
        public int? IlId { get; set; }
    }
}
