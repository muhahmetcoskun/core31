using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class LanguageName
    {
        public int YabanciDilId { get; set; }
        public string? YabanciDil { get; set; }
        public byte? Durum { get; set; }
    }
}
