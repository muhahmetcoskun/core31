namespace Entities.RequestFeatures
{
    public class AdminParameters : RequestParameters
	{
        public String? Adi { get; set; }
        public String? Soyadi { get; set; }
        public String? SearchTerm { get; set; }

		public AdminParameters()
		{
			OrderBy = "id";
		}
	}
}
