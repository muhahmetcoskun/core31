using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.DataTransferObjects.GunlukCalismaSuresi;
using Entities.Models;
using Entities.RequestFeatures;
using System.Dynamic;

namespace Services.Contracts
{
    public interface IGunlukCalismaSuresiService
    {
        Task<(IEnumerable<ExpandoObject> gunlukCalismaSuresies, MetaData metaData)> GetAllGunlukCalismaSuresiesAsync(GunlukCalismaSuresiParameters gunlukCalismaSuresiParameters, bool trackChanges);
        Task<GunlukCalismaSuresiDto> GetOneGunlukCalismaSuresiByIdAsync(int id, bool trackChanges);
        Task<GunlukCalismaSuresiDto> CreateOneGunlukCalismaSuresiAsync(GunlukCalismaSuresiDtoForInsertion gunlukCalismaSuresi);
        Task UpdateOneGunlukCalismaSuresiAsync(int id, GunlukCalismaSuresiDtoForUpdate gunlukCalismaSuresiDto, bool trackChanges);
        Task DeleteOneGunlukCalismaSuresiAsync(int id, bool trackChanges);
        Task<List<GunlukCalismaSuresi>> GetAllGunlukCalismaSuresiesAsync(bool trackChanges);
    }
}
