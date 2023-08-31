using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Adaptation
    {
        public int PersonelIntibakId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? HizmetinGecYerId { get; set; }
        public string? HizmetinGecKurum { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public string? PrimGunSayisi { get; set; }
        public byte? Durum { get; set; }
    }
}
