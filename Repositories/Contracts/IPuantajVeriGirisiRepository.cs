using Entities.Models;
using Entities.RequestFeatures;

namespace Repositories.Contracts
{
    public interface IPuantajVeriGirisiRepository : IRepositoryBase<PuantajVeriGirisi>
    {
        Task<PagedList<PuantajVeriGirisi>> GetAllPuantajVeriGirisisAsync(PuantajVeriGirisiParameters puantajVeriGirisiParameters,bool trackChanges);
        Task<List<PuantajVeriGirisi>> GetAllPuantajVeriGirisisAsync(bool trackChanges);
        Task<PuantajVeriGirisi> GetOnePuantajVeriGirisiByIdAsync(int id, bool trackChanges);
        void CreateOnePuantajVeriGirisi(PuantajVeriGirisi puantajVeriGirisi);
        void UpdateOnePuantajVeriGirisi(PuantajVeriGirisi puantajVeriGirisi);
        void DeleteOnePuantajVeriGirisi(PuantajVeriGirisi puantajVeriGirisi);
        Task<IEnumerable<PuantajVeriGirisi>> GetAllPuantajVeriGirisiesWithDetailsAsync(bool trackChanges);

    }
}
