using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ModulCod
    {
        public int Id { get; set; }
        public int? ModulId { get; set; }
        public string? ModulName { get; set; }
        public byte? ModulStatus { get; set; }
    }
}
