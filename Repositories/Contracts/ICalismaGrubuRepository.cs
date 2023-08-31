using Entities.Models;
using Entities.RequestFeatures;

namespace Repositories.Contracts
{
    public interface ICalismaGrubuRepository : IRepositoryBase<CalismaGrubu>
    {
        Task<PagedList<CalismaGrubu>> GetAllCalismaGrubusAsync(CalismaGrubuParameters calismaGrubuParameters, bool trackChanges);
        Task<List<CalismaGrubu>> GetAllCalismaGrubusAsync(bool trackChanges);
        Task<CalismaGrubu> GetOneCalismaGrubuByIdAsync(int id, bool trackChanges);
        void CreateOneCalismaGrubu(CalismaGrubu calismaGrubu);
        void UpdateOneCalismaGrubu(CalismaGrubu calismaGrubu);
        void DeleteOneCalismaGrubu(CalismaGrubu calismaGrubu);

    }
}
