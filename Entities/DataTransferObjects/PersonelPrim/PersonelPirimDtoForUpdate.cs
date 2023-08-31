using Entities.DataTransferObjects.PrimTuru;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.PersonelPrim
{
    public record PersonelPrimDtoForUpdate : PersonelPrimDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }
}
