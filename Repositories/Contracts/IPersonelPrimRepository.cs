using Entities.Models;
using Entities.RequestFeatures;

namespace Repositories.Contracts
{
    public interface IPersonelPrimRepository : IRepositoryBase<PersonelPrim>
    {
        Task<PagedList<PersonelPrim>> GetAllPersonelPrimsAsync(PersonelPrimParameters personelPrimParameters, bool trackChanges);
        Task<List<PersonelPrim>> GetAllPersonelPrimsAsync(bool trackChanges);
        Task<PersonelPrim> GetOnePersonelPrimByIdAsync(int id, bool trackChanges);
        void CreateOnePersonelPrim(PersonelPrim personelPrim);
        void UpdateOnePersonelPrim(PersonelPrim personelPrim);
        void DeleteOnePersonelPrim(PersonelPrim personelPrim);

    }
}
