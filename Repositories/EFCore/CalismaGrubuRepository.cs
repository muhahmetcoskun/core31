using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;

namespace Repositories.EFCore
{
    public sealed class CalismaGrubuRepository : RepositoryBase<CalismaGrubu>, ICalismaGrubuRepository
    {
        public CalismaGrubuRepository(RepositoryContext context) : base(context)
        {
            
        }
        public void CreateOneCalismaGrubu(CalismaGrubu calismaGrubu) => Create(calismaGrubu);
        public void DeleteOneCalismaGrubu(CalismaGrubu calismaGrubu) => Update(calismaGrubu);
        public async Task<List<CalismaGrubu>> GetAllCalismaGrubusAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
        public async Task<PagedList<CalismaGrubu>> GetAllCalismaGrubusAsync(CalismaGrubuParameters calismaGrubuParameters, bool trackChanges)
        {
            var calismaGrubu = await FindAll(trackChanges)
             .FilterPersonelPrims(calismaGrubuParameters.PersonelId,
              calismaGrubuParameters.OOMesaiBaslamaSaati, calismaGrubuParameters.OOMesaiBitisSaati,
              calismaGrubuParameters.YemekMolasiBaslamaSaati, calismaGrubuParameters.YemekMolasiBitisSaati,
              calismaGrubuParameters.OSMesaiBaslamaSaati, calismaGrubuParameters.OSMesaiBitisSaati,
              calismaGrubuParameters.HaftalikCalismaSuresi, calismaGrubuParameters.HaftaTatiliGunu,
              calismaGrubuParameters.Aktif)
             .Sort(calismaGrubuParameters.OrderBy)
             .ToListAsync();

            return PagedList<CalismaGrubu>
                .ToPagedList(calismaGrubu,
                calismaGrubuParameters.PageNumber,
                calismaGrubuParameters.PageSize);
        }
        public async Task<CalismaGrubu> GetOneCalismaGrubuByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        public void UpdateOneCalismaGrubu(CalismaGrubu calismaGrubu) => Update(calismaGrubu);
    }
}
