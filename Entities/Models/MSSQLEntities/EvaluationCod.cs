using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class EvaluationCod
    {
        public int Id { get; set; }
        public int? DegerlendirmeId { get; set; }
        public string? DegerlendirmeAdi { get; set; }
    }
}
