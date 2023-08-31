namespace Entities.Exceptions
{
    public sealed class PersonelPrimNotFoundException : NotFoundException
    {
        public PersonelPrimNotFoundException(int id) 
            : base($"Personel prim id : {id} bulunamadı.")
        {
        }
    }
}
