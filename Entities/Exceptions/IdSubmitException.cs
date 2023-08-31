namespace Entities.Exceptions
{
    public sealed class IdSubmitException : NotFoundException
    {
        public IdSubmitException(int id) 
            : base($"Id gönderilmemesi gerekiyor : {id} ")
        {
        }
    }
}
