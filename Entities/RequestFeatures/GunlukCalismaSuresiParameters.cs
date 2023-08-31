namespace Entities.RequestFeatures
{
    public class GunlukCalismaSuresiParameters : RequestParameters
	{
        public uint SiraNo { get; set; }
        public string Adi{ get; set; }
        public Boolean Aktif { get; set; }

        public String? SearchTerm { get; set; }
        public GunlukCalismaSuresiParameters()
		{
			OrderBy = "id";
		}
	}
}
