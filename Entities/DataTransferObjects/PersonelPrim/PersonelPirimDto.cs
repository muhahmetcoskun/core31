namespace Entities.DataTransferObjects.PersonelPrim
{
    public record PersonelPrimDto
    {
        public int Id { get; init; }
        public int PrimTuruId { get; init; }
        public int PersonelId { get; init; }
        public Boolean Aktif { get; init; }
    }
}
