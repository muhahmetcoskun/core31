using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.PersonelPrim
{
    public record PersonelPrimDtoForInsertion : PersonelPrimDtoForManipulation
    {
        public int Id { get; init; }
    }
}
