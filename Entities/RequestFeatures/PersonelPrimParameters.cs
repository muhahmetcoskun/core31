namespace Entities.RequestFeatures
{
    public class PersonelPrimParameters : RequestParameters
	{
        public uint PrimTuruId { get; set; }
        public uint PersonelId { get; set; }
        public Boolean Aktif { get; set; }

		public PersonelPrimParameters()
		{
			OrderBy = "id";
		}
	}
}
