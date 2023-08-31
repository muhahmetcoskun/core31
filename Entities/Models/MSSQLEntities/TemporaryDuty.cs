using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class TemporaryDuty
    {
        public int PersonelGeciciGorevId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? GeciciGorevNedenId { get; set; }
        public int? GorevYeriId { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public byte? Durum { get; set; }
    }
}
