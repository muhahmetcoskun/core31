namespace Entities.DataTransferObjects.GunlukCalismaSuresi
{
    public record GunlukCalismaSuresiDto
    {
        public int Id { get; init; }
        public int SiraNo { get; init; }
        public string Adi { get; init; }
        public Boolean Aktif { get; init; }
    }
}
