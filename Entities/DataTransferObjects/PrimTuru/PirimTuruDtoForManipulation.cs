using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PrimTuru
{
    public abstract record PrimTuruDtoForManipulation
    {
        [Required(ErrorMessage = "Sıra no zorunlu.")]
        public int SiraNo { get; init; }

        [Required(ErrorMessage = "Adı zorunlu.")]
        public string Adi { get; init; }

        public Boolean Aktif { get; init; } = true;
    }
}
