using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.ResmiTatil
{
    public record ResmiTatilDtoForInsertion : ResmiTatilDtoForManipulation
    {
        public int Id { get; init; }
    }
}
