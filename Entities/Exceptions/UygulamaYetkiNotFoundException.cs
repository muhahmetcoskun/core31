namespace Entities.Exceptions
{
    public sealed class UygulamaYetkiNotFoundException : NotFoundException
    {
        public UygulamaYetkiNotFoundException(int id) 
            : base($"Uygulama id : {id} bulunamadı.")
        {
        }
    }
}
