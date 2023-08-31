using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Permission
    {
        public int PersonelIzinId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public int? IzinTurId { get; set; }
        public int? IzinNedenId { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public byte? Durum { get; set; }
        public string? BaslamaSaat { get; set; }
        public string? BitisSaat { get; set; }
    }
}
