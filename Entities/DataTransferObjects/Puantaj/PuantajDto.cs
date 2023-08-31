namespace Entities.DataTransferObjects.Puantaj
{
    public record PuantajDto
    {
        public int Id { get; init; }
        public DateTime BaslangicDonem { get; init; }
        public DateTime BitisDonem { get; init; }
        public DateTime KapamaTarihi { get; init; }
    }
}
