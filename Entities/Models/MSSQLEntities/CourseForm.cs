using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class CourseForm
    {
        public int KursSekliId { get; set; }
        public string? KursSekli { get; set; }
        public byte? Durum { get; set; }
    }
}
