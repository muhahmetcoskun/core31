using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class JobHistory
    {
        public int PersonelSafahatId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? SafahatSekliId { get; set; }
        public int? SafahatGerekceId { get; set; }
        public DateTime? OnayTarihi { get; set; }
        public DateTime? KatilisTarihi { get; set; }
        public DateTime? AyrilisTarihi { get; set; }
        public int? IsyeriId { get; set; }
        public int? GorevId { get; set; }
        public byte? Durum { get; set; }
    }
}
