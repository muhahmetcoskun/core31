using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class DesignationNews
    {
        public int PersonelAtamaId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public string? IsyeriId { get; set; }
        public string? MevcutIsyeriId { get; set; }
        public string? AtamaIstegiNedenId { get; set; }
        public int? IlId { get; set; }
        public DateTime? NakilTalepTarihi { get; set; }
        public DateTime? KatilisTarihi { get; set; }
        public DateTime? AyrilisTarihi { get; set; }
        public int? NakilDurumId { get; set; }
        public string? Aciklama { get; set; }
        public int? IsVerenVekiliOnayId { get; set; }
        public int? IlgiliGenelMudurOnayId { get; set; }
        public int? PersonelGenelMudurOnayId { get; set; }
        public int? TopluNakilId { get; set; }
        public byte? Durum { get; set; }
        public bool? EskiNakilVarMi { get; set; }
        public int? TisMeslekKodId { get; set; }
        public int? NakledildigiIsyeriId { get; set; }
        public string? AmirAciklama { get; set; }
        public string? IsverenAciklama { get; set; }
        public string? GmudurAciklama { get; set; }
        public string? Pgmaciklama { get; set; }
        public DateTime? AmirOnayTarihi { get; set; }
        public DateTime? IsVerenOnayTarihi { get; set; }
        public DateTime? GmonayTarihi { get; set; }
        public DateTime? PgmonayTarihi { get; set; }
        public int? NakledilenTisMeslekId { get; set; }
    }
}
