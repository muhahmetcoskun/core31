namespace Entities.Exceptions
{
    public sealed class ResmiTatilNotFoundException : NotFoundException
    {
        public ResmiTatilNotFoundException(int id) 
            : base($"Resmi Tatil id : {id} bulunamadı.")
        {
        }
    }
}
