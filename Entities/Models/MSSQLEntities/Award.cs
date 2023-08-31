using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Award
    {
        public int PersonelOdulId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? OdulTaktirBilgiId { get; set; }
        public DateTime? VerildigiTarih { get; set; }
        public string? OdulVerenAmirRutbe { get; set; }
        public string? OdulVerenAmirAdi { get; set; }
        public string? OdulVerenAmirSoyadi { get; set; }
        public byte? Durum { get; set; }
    }
}
