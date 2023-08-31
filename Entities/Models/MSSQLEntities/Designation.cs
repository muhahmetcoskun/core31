using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Designation
    {
        public int PersonelAtamaId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public string? IsyeriId { get; set; }
        public int? AtamaIstegiNedenId { get; set; }
        public DateTime? NakilTalepTarihi { get; set; }
        public DateTime? KatilisTarihi { get; set; }
        public DateTime? AyrilisTarihi { get; set; }
        public int? NakilDurumId { get; set; }
        public string? Aciklama { get; set; }
        public int? IlgiliGenelMudurOnayId { get; set; }
        public int? PersonelGenelMudurOnayId { get; set; }
        public int? IsVerenVekiliOnayId { get; set; }
        public int? TopluNakilId { get; set; }
        public byte? Durum { get; set; }
        public bool? EskiNakilVarMi { get; set; }
        public int? TisMeslekKodId { get; set; }
        public int? NakledildigiIsyeriId { get; set; }
        public int? NakledilenTisMeslekId { get; set; }
        public int? BulunduguIsyeriId { get; set; }
    }
}
