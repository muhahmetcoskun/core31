using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.CalismaGrubu
{
    public abstract record CalismaGrubuDtoForManipulation
    {
        [Required(ErrorMessage = "Personel zorunlu.")]
        public int PersonelId { get; init; }

        [Required(ErrorMessage = "Öğleden önce mesai başlama saati zorunlu.")]
        public TimeOnly OOMesaiBaslamaSaati { get; set; }

        [Required(ErrorMessage = "Öğleden önce mesai bitiş saati zorunlu.")]
        public TimeOnly OOMesaiBitisSaati { get; set; }

        [Required(ErrorMessage = "Yemek molası başlama saati zorunlu.")]
        public TimeOnly YemekMolasiBaslamaSaati { get; set; }

        [Required(ErrorMessage = "Yemek molası bitiş saati zorunlu.")]
        public TimeOnly YemekMolasiBitisSaati { get; set; }

        [Required(ErrorMessage = "Öğleden sonra mesai başlama saati zorunlu.")]
        public TimeOnly OSMesaiBaslamaSaati { get; set; }

        [Required(ErrorMessage = "Öğleden sonra mesai bitiş saati zorunlu.")]
        public TimeOnly OSMesaiBitisSaati { get; set; }

        [Required(ErrorMessage = "Haftalık çalışma süresi zorunlu.")]
        public int HaftalikCalismaSuresi { get; set; }

        [Required(ErrorMessage = "Hafta tatili günü zorunlu.")]
        public int HaftaTatiliGunu { get; set; }

        public Boolean Aktif { get; init; } = true;
    }
}
