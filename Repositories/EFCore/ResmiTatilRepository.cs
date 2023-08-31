using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;

namespace Repositories.EFCore
{
    public sealed class ResmiTatilRepository : RepositoryBase<ResmiTatil>, IResmiTatilRepository
    {
        public ResmiTatilRepository(RepositoryContext context) : base(context)
        {
            
        }
        public void CreateOneResmiTatil(ResmiTatil resmiTatil) => Create(resmiTatil);
        public void DeleteOneResmiTatil(ResmiTatil resmiTatil) => Update(resmiTatil);
        public async Task<List<ResmiTatil>> GetAllResmiTatilsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                //.Where(s => s.Aktif == 1)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
        public async Task<PagedList<ResmiTatil>> GetAllResmiTatilsAsync(ResmiTatilParameters resmiTatilParameters, bool trackChanges)
        {
            var resmiTatil = await FindAll(trackChanges)
             .FilterResmiTatils(resmiTatilParameters.Aktif, resmiTatilParameters.Tarih)
             .Sort(resmiTatilParameters.OrderBy)
             .ToListAsync();

            return PagedList<ResmiTatil>
                .ToPagedList(resmiTatil,
                resmiTatilParameters.PageNumber,
                resmiTatilParameters.PageSize);
        }
        public async Task<ResmiTatil> GetOneResmiTatilByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        public void UpdateOneResmiTatil(ResmiTatil resmiTatil) => Update(resmiTatil);
    }
}
