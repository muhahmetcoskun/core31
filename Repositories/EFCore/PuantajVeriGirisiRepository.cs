using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;

namespace Repositories.EFCore
{
    public sealed class PuantajVeriGirisiRepository : RepositoryBase<PuantajVeriGirisi>, IPuantajVeriGirisiRepository
    {
        public PuantajVeriGirisiRepository(RepositoryContext context) : base(context)
        {
            
        }
        public void CreateOnePuantajVeriGirisi(PuantajVeriGirisi puantajVeriGirisi) => Create(puantajVeriGirisi);
        public void DeleteOnePuantajVeriGirisi(PuantajVeriGirisi puantajVeriGirisi) => Update(puantajVeriGirisi);
        public async Task<List<PuantajVeriGirisi>> GetAllPuantajVeriGirisisAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
        public async Task<PagedList<PuantajVeriGirisi>> GetAllPuantajVeriGirisisAsync(PuantajVeriGirisiParameters puantajVeriGirisiParameters, 
            bool trackChanges)
        {
            var puantajVeriGirisi = await FindAll(trackChanges)
             .FilterPuantajVeriGirisis(puantajVeriGirisiParameters.KategoriTipiId)
             .Search(puantajVeriGirisiParameters.SearchTerm)
             .Sort(puantajVeriGirisiParameters.OrderBy)
             .ToListAsync();

            return PagedList<PuantajVeriGirisi>
                .ToPagedList(puantajVeriGirisi,
                puantajVeriGirisiParameters.PageNumber,
                puantajVeriGirisiParameters.PageSize);
        }
        public async Task<PuantajVeriGirisi> GetOnePuantajVeriGirisiByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        public void UpdateOnePuantajVeriGirisi(PuantajVeriGirisi puantajVeriGirisi) => Update(puantajVeriGirisi);
        public async Task<IEnumerable<PuantajVeriGirisi>> GetAllPuantajVeriGirisiesWithDetailsAsync(bool trackChanges)
        {
            return await _context
                .PuantajVeriGirisies
                .Include(b => b.KategoriTipi)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
    }
}
