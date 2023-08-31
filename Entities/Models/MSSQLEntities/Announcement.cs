using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Announcement
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public string? DuyuruBaslik { get; set; }
        public string? Duyuru { get; set; }
        public byte? DuyuruDurum { get; set; }
    }
}
