using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class BirthCertificate
    {
        public int PersonelNufusId { get; set; }
        public int? PersonelKimlikId { get; set; }
        public string? SeriNo { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? MahalleKoy { get; set; }
        public string? CiltNo { get; set; }
        public string? SiraNo { get; set; }
        public string? AileSiraNo { get; set; }
    }
}
