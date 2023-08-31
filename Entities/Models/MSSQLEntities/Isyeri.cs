using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class Isyeri
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public int? UstIsyeriId { get; set; }
    }
}
