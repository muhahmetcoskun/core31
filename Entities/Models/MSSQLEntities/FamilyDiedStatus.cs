using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class FamilyDiedStatus
    {
        public int? VefatDurumuId { get; set; }
        public string? VefatDurumu { get; set; }
        public byte? Durum { get; set; }
    }
}
