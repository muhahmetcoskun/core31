namespace Entities.RequestFeatures
{
    public class PuantajParameters : RequestParameters
	{
        public DateTime BaslangicDonemi { get; set; }
        public DateTime BitisDonemi { get; set; }
        public String? SearchTerm { get; set; }

		public PuantajParameters()
		{
			OrderBy = "id";
		}
	}
}
