namespace Entities.Exceptions
{
    public sealed class PuantajVeriGirisiNotFoundException : NotFoundException
    {
        public PuantajVeriGirisiNotFoundException(int id) 
            : base($"Puantaj veri girişi id : {id} bulunamadı.")
        {
        }
    }
}
