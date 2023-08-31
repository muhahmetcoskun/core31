namespace Entities.Exceptions
{
    public sealed class PuantajNotFoundException : NotFoundException
    {
        public PuantajNotFoundException(int id) 
            : base($"Puantaj id : {id} tanımsız.")
        {
        }
    }
}
