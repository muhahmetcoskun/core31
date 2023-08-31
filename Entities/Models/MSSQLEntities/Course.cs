using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Course
    {
        public int PersonelKursId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? KursTuruId { get; set; }
        public int? KursSekliId { get; set; }
        public string? Konusu { get; set; }
        public string? KursSinavAdi { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public byte? Durum { get; set; }
    }
}
