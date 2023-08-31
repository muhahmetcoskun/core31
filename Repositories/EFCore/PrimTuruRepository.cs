using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;

namespace Repositories.EFCore
{
    public sealed class PrimTuruRepository : RepositoryBase<PrimTuru>, IPrimTuruRepository
    {
        public PrimTuruRepository(RepositoryContext context) : base(context)
        {
            
        }
        public void CreateOnePrimTuru(PrimTuru primTuru) => Create(primTuru);
        public void DeleteOnePrimTuru(PrimTuru primTuru) => Update(primTuru);
        public async Task<List<PrimTuru>> GetAllPrimTurusAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
        public async Task<PagedList<PrimTuru>> GetAllPrimTurusAsync(PrimTuruParameters primTuruParameters, bool trackChanges)
        {
            var primTuru = await FindAll(trackChanges)
             .FilterPrimTurus(primTuruParameters.SiraNo, primTuruParameters.Adi,primTuruParameters.Aktif)
             .Search(primTuruParameters.SearchTerm)
             .Sort(primTuruParameters.OrderBy)
             .ToListAsync();

            return PagedList<PrimTuru>
                .ToPagedList(primTuru,
                primTuruParameters.PageNumber,
                primTuruParameters.PageSize);
        }
        public async Task<PrimTuru> GetOnePrimTuruByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        public void UpdateOnePrimTuru(PrimTuru primTuru) => Update(primTuru);
    }
}
