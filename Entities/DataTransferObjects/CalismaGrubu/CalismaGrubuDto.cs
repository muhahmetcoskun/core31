namespace Entities.DataTransferObjects.CalismaGrubu
{
    public record CalismaGrubuDto
    {
        public int Id { get; init; }
        public int PersonelelId { get; init; }
        public TimeOnly OOMesaiBaslamaSaati { get; init; }
        public TimeOnly OOMesaiBitisSaati { get; init; }
        public TimeOnly YemekMolasiBaslamaSaati { get; init; }
        public TimeOnly YemekMolasiBitisSaati { get; init; }
        public TimeOnly OSMesaiBaslamaSaati { get; init; }
        public TimeOnly OSMesaiBitisSaati { get; init; }
        public int HaftalikCalismaSuresi { get; init; }
        public int HaftaTatiliGunu { get; init; }
        public Boolean Aktif { get; set; }
    }
}
