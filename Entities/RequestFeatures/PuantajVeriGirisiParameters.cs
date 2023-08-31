namespace Entities.RequestFeatures
{
    public class PuantajVeriGirisiParameters : RequestParameters
	{
        public uint KategoriTipiId { get; set; }
        public String? SearchTerm { get; set; }

		public PuantajVeriGirisiParameters()
		{
			OrderBy = "id";
		}
	}
}
