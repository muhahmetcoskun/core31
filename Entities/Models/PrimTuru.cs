using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Index(nameof(SiraNo), IsUnique = true)]
    public class PrimTuru
    {
        public int Id { get; set; }
        public int SiraNo { get; set; }
        public String? Adi { get; set; }
        public Boolean Aktif { get; set; }
    }
}
