using Entities.DataTransferObjects.CalismaGrubu;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.CalismaGrubu
{
    public record CalismaGrubuDtoForInsertion : CalismaGrubuDtoForManipulation
    {
        public int Id { get; init; }
    }
}
