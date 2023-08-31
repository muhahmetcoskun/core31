namespace Entities.Exceptions
{
    public sealed class CalismaGrubuNotFoundException : NotFoundException
    {
        public CalismaGrubuNotFoundException(int id) 
            : base($"Çalışma grubu id : {id} bulunamadı.")
        {
        }
    }
}
