namespace Entities.Models
{
    public class PuantajVeriGirisi
    {
        public int Id { get; set; }
        public String VeriGirisi { get; set; }
        public String Dayanak { get; set; }
        public String Simge { get; set; }
        public Boolean Aktif { get; set; }

        // Ref: navigation property
        public int KategoriTipiId { get; set; }
        public KategoriTipi KategoriTipi { get; set; }
    }
}
