using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Communication
    {
        public int PersonelIletisimId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? IlId { get; set; }
        public string? Ilce { get; set; }
        public string? Adres { get; set; }
        public string? CepTel { get; set; }
        public string? Tafics { get; set; }
    }
}
