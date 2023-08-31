using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class DesignationStore
    {
        public int PersonelHavuzId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public string? IsyeriId { get; set; }
        public int? KatilisIsyeriId { get; set; }
        public DateTime? AyrilisTarih { get; set; }
        public DateTime? KatilisTarih { get; set; }
        public int? NakledilenTisMeslekId { get; set; }
        public byte? Durum { get; set; }
    }
}
