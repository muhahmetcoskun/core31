using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class CourseType
    {
        public int KursTuruId { get; set; }
        public string? KursTuruKodu { get; set; }
        public string? KursTuru { get; set; }
        public byte? Durum { get; set; }
    }
}
