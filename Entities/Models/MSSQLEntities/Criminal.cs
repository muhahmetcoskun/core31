using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Criminal
    {
        public int PersonelCezaId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public string? CezaVerenAmir { get; set; }
        public int? VerilenCezaId { get; set; }
        public int? CezaNedenId { get; set; }
        public DateTime? CezaTarihi { get; set; }
        public string? CezayiVerenKisiAdi { get; set; }
        public byte? Durum { get; set; }
        public DateTime? SucTarihi { get; set; }
    }
}
