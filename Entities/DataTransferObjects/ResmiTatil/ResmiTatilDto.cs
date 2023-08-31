namespace Entities.DataTransferObjects.ResmiTatil
{
    public record ResmiTatilDto
    {
        public int Id { get; init; }
        public DateTime Tarih { get; init; }
        public Boolean Aktif { get; init; }

    }
}
