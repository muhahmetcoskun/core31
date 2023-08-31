using Entities.Models;
using Entities.RequestFeatures;

namespace Repositories.Contracts
{
    public interface IResmiTatilRepository : IRepositoryBase<ResmiTatil>
    {
        Task<PagedList<ResmiTatil>> GetAllResmiTatilsAsync(ResmiTatilParameters resmiTatilParameters, bool trackChanges);
        Task<List<ResmiTatil>> GetAllResmiTatilsAsync(bool trackChanges);
        Task<ResmiTatil> GetOneResmiTatilByIdAsync(int id, bool trackChanges);
        void CreateOneResmiTatil(ResmiTatil resmiTatil);
        void UpdateOneResmiTatil(ResmiTatil resmiTatil);
        void DeleteOneResmiTatil(ResmiTatil resmiTatil);

    }
}
