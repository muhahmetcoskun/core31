using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CalismaGrubu
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public TimeOnly OOMesaiBaslamaSaati { get; set; }
        public TimeOnly OOMesaiBitisSaati { get; set; }
        public TimeOnly YemekMolasiBaslamaSaati { get; set; }
        public TimeOnly YemekMolasiBitisSaati { get; set; }
        public TimeOnly OSMesaiBaslamaSaati { get; set; }
        public TimeOnly OSMesaiBitisSaati { get; set; }
        public int HaftalikCalismaSuresi { get; set; }
        public int HaftaTatiliGunu { get; set; }
        public Boolean Aktif { get; set; }
    }
}
