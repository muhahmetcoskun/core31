using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Puantaj
{
    public record PuantajDtoForInsertion : PuantajDtoForManipulation
    {
        public int Id { get; init; }
    }
}
