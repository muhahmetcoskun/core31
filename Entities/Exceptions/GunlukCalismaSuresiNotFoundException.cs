namespace Entities.Exceptions
{
    public sealed class GunlukCalismaSuresiNotFoundException : NotFoundException
    {
        public GunlukCalismaSuresiNotFoundException(int id) 
            : base($"Günlük çalışma süresi id : {id} bulunamadı.")
        {
        }
    }
}
