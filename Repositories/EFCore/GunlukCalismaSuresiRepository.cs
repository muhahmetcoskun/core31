using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;

namespace Repositories.EFCore
{
    public sealed class GunlukCalismaSuresiRepository : RepositoryBase<GunlukCalismaSuresi>, IGunlukCalismaSuresiRepository
    {
        public GunlukCalismaSuresiRepository(RepositoryContext context) : base(context)
        {
            
        }
        public void CreateOneGunlukCalismaSuresi(GunlukCalismaSuresi gunlukCalismaSuresi) => Create(gunlukCalismaSuresi);
        public void DeleteOneGunlukCalismaSuresi(GunlukCalismaSuresi gunlukCalismaSuresi) => Update(gunlukCalismaSuresi);
        public async Task<List<GunlukCalismaSuresi>> GetAllGunlukCalismaSuresisAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
        public async Task<PagedList<GunlukCalismaSuresi>> GetAllGunlukCalismaSuresisAsync(GunlukCalismaSuresiParameters gunlukCalismaSuresiParameters, bool trackChanges)
        {
            var gunlukCalismaSuresi = await FindAll(trackChanges)
             .FilterGunlukCalismaSuresis(gunlukCalismaSuresiParameters.SiraNo, gunlukCalismaSuresiParameters.Adi,gunlukCalismaSuresiParameters.Aktif)
             .Search(gunlukCalismaSuresiParameters.SearchTerm)
             .Sort(gunlukCalismaSuresiParameters.OrderBy)
             .ToListAsync();

            return PagedList<GunlukCalismaSuresi>
                .ToPagedList(gunlukCalismaSuresi,
                gunlukCalismaSuresiParameters.PageNumber,
                gunlukCalismaSuresiParameters.PageSize);
        }
        public async Task<GunlukCalismaSuresi> GetOneGunlukCalismaSuresiByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        public void UpdateOneGunlukCalismaSuresi(GunlukCalismaSuresi gunlukCalismaSuresi) => Update(gunlukCalismaSuresi);
    }
}
