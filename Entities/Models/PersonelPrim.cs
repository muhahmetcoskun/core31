using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PersonelPrim
    {
        public int Id { get; set; }
        public int PrimTuruId { get; set; }
        public int PersonelId { get; set; }
        public Boolean Aktif { get; set; }
        public PrimTuru PrimTuru { get; set; }
    }
}
