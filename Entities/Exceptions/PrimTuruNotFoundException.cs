namespace Entities.Exceptions
{
    public sealed class PrimTuruNotFoundException : NotFoundException
    {
        public PrimTuruNotFoundException(int id) 
            : base($"Prim turu id : {id} bulunamadı.")
        {
        }
    }
}
