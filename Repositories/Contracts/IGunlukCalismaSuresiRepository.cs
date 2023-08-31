using Entities.Models;
using Entities.RequestFeatures;

namespace Repositories.Contracts
{
    public interface IGunlukCalismaSuresiRepository : IRepositoryBase<GunlukCalismaSuresi>
    {
        Task<PagedList<GunlukCalismaSuresi>> GetAllGunlukCalismaSuresisAsync(GunlukCalismaSuresiParameters gunlukCalismaSuresiParameters, bool trackChanges);
        Task<List<GunlukCalismaSuresi>> GetAllGunlukCalismaSuresisAsync(bool trackChanges);
        Task<GunlukCalismaSuresi> GetOneGunlukCalismaSuresiByIdAsync(int id, bool trackChanges);
        void CreateOneGunlukCalismaSuresi(GunlukCalismaSuresi gunlukCalismaSuresi);
        void UpdateOneGunlukCalismaSuresi(GunlukCalismaSuresi gunlukCalismaSuresi);
        void DeleteOneGunlukCalismaSuresi(GunlukCalismaSuresi gunlukCalismaSuresi);

    }
}
