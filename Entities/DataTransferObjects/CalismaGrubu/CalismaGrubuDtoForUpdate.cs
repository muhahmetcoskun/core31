using Entities.DataTransferObjects.PrimTuru;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.CalismaGrubu
{
    public record CalismaGrubuDtoForUpdate : CalismaGrubuDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }
}
