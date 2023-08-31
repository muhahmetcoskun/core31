using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;

namespace Repositories.EFCore
{
    public sealed class UygulamaYetkiRepository : RepositoryBase<UygulamaYetki>, IUygulamaYetkiRepository
    {
        public UygulamaYetkiRepository(RepositoryContext context) : base(context)
        {
            
        }
        public void CreateOneUygulamaYetki(UygulamaYetki uygulamaYetki) => Create(uygulamaYetki);
        public void DeleteOneUygulamaYetki(UygulamaYetki uygulamaYetki) => Update(uygulamaYetki);
        public async Task<List<UygulamaYetki>> GetAllUygulamaYetkiesAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                  .OrderBy(b => b.Id)
                  .ToListAsync();
        }
        public async Task<PagedList<UygulamaYetki>> GetAllUygulamaYetkiesAsync(UygulamaYetkiParameters uygulamaYetkiParameters, bool trackChanges)
        {
            var uygulamaYetki = await FindAll(trackChanges)
             .FilterUygulamaYetkies(uygulamaYetkiParameters.UygulamaId, uygulamaYetkiParameters.RolId, uygulamaYetkiParameters.UserId, uygulamaYetkiParameters.Aktif)
             .Sort(uygulamaYetkiParameters.OrderBy)
             .ToListAsync();

            return PagedList<UygulamaYetki>
                .ToPagedList(uygulamaYetki,
                uygulamaYetkiParameters.PageNumber,
                uygulamaYetkiParameters.PageSize);
        }
        public async Task<UygulamaYetki> GetOneUygulamaYetkiByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        public void UpdateOneUygulamaYetki(UygulamaYetki uygulamaYetki) => Update(uygulamaYetki);
        public async Task<IEnumerable<UygulamaYetki>> GetAllUygulamaYetkiesWithDetailsAsync(bool trackChanges)
        {
            return await _context
                .UygulamaYetkies
                .Include(u => u.UygulamaId)
                .Include(r => r.RolId)
                .Include(y => y.UserId)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
    }
}
