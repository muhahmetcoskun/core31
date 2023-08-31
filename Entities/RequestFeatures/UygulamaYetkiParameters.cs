namespace Entities.RequestFeatures
{
    public class UygulamaYetkiParameters : RequestParameters
	{
        public uint UygulamaId { get; set; }
        public uint RolId { get; set; }
        public uint UserId { get; set; }
        public Boolean Aktif { get; set; }

		public UygulamaYetkiParameters()
		{
			OrderBy = "id";
		}
	}
}
