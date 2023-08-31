using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Military
    {
        public int PersonelAskerlikId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? AskerlikDurumId { get; set; }
        public DateTime? AskerlikBasTarih { get; set; }
        public DateTime? TerhisTarih { get; set; }
        public string? HizmetSuresi { get; set; }
        public string? Statu { get; set; }
        public string? BorclanmaDurumu { get; set; }
        public DateTime? AskerlikSonrasiIseBaslamaTarih { get; set; }
    }
}
