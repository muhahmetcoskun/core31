using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Request
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? AdminId { get; set; }
        public int? ModulId { get; set; }
        public string? Aciklama { get; set; }
        public int? DegerlendirmeId { get; set; }
        public string? Cevap { get; set; }
        public byte? IstekDurum { get; set; }
        public DateTime? IstekTarih { get; set; }
        public DateTime? CevapTarih { get; set; }
    }
}
