using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PersonelPrim
{
    public abstract record PersonelPrimDtoForManipulation
    {
        [Required(ErrorMessage = "Prim türü zorunlu.")]
        public int PrimTuruId { get; init; }
        public int PersonelId { get; init; }
        public Boolean Aktif { get; init; } = true;
    }
}
