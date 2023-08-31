namespace Entities.DataTransferObjects.PuantajVeriGirisi
{
    public record PuantajVeriGirisiDto
    {
        public int Id { get; init; }
        public string VeriGirisi { get; init; }
        public string Dayanak { get; init; }
        public string Simge { get; init; }
        public Boolean Aktif { get; init; }
    }
}
