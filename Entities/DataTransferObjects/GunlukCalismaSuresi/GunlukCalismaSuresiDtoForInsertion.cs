using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.GunlukCalismaSuresi
{
    public record GunlukCalismaSuresiDtoForInsertion : GunlukCalismaSuresiDtoForManipulation
    {
        public int Id { get; init; }
    }
}
