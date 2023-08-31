using Entities.Models;
using Entities.RequestFeatures;

namespace Repositories.Contracts
{
    public interface IPrimTuruRepository : IRepositoryBase<PrimTuru>
    {
        Task<PagedList<PrimTuru>> GetAllPrimTurusAsync(PrimTuruParameters primTuruParameters, bool trackChanges);
        Task<List<PrimTuru>> GetAllPrimTurusAsync(bool trackChanges);
        Task<PrimTuru> GetOnePrimTuruByIdAsync(int id, bool trackChanges);
        void CreateOnePrimTuru(PrimTuru primTuru);
        void UpdateOnePrimTuru(PrimTuru primTuru);
        void DeleteOnePrimTuru(PrimTuru primTuru);

    }
}
