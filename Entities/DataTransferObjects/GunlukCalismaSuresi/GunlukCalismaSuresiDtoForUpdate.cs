using Entities.DataTransferObjects.PrimTuru;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.GunlukCalismaSuresi
{
    public record GunlukCalismaSuresiDtoForUpdate : GunlukCalismaSuresiDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }
}
