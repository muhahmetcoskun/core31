using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.PrimTuru
{
    public record PrimTuruDtoForInsertion : PrimTuruDtoForManipulation
    {
        public int Id { get; init; }
    }
}
