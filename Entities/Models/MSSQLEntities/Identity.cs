using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Identity
    {
        public int PersonelKimlikId { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? KizlikSoyadi { get; set; }
        public int? MedeniHalId { get; set; }
        public int? CinsiyetId { get; set; }
        public int? KanGrupId { get; set; }
        public int? IstihtamDurumId { get; set; }
        public int? MevcutStatuId { get; set; }
        public int? ServisBilgiId { get; set; }
        public int? VardiyaBilgiId { get; set; }
        public string? SosyalGüvenlikNo { get; set; }
        public int? TisMeslekKolId { get; set; }
        public int? SgkMeslekKolId { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? DogumYeri { get; set; }
        public string? AnaAdi { get; set; }
        public string? BabaAdi { get; set; }
        public DateTime? MsbKatilisTarih { get; set; }
        public int? IsyeriId { get; set; }
        public int? IdarecilikDurumId { get; set; }
        public string? CocukSayisi { get; set; }
        public int? UstIsyeriId { get; set; }
        public int? IsdihtamSekliId { get; set; }
        public int? Tmsyid { get; set; }
        public DateTime? IstihdamAyrilisTarih { get; set; }
        public string? IstihdamAciklama { get; set; }
        public DateTime? SgkgirisTarihi { get; set; }
    }
}
