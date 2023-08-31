namespace Entities.RequestFeatures
{
    public class ResmiTatilParameters : RequestParameters
    {
        public DateTime Tarih { get; set; }
        public Boolean Aktif { get; set; }

		public ResmiTatilParameters()
		{
			OrderBy = "id";
		}
	}
}
