using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;

namespace Repositories.EFCore
{
    public sealed class PersonelPrimRepository : RepositoryBase<PersonelPrim>, IPersonelPrimRepository
    {
        public PersonelPrimRepository(RepositoryContext context) : base(context)
        {
            
        }
        public void CreateOnePersonelPrim(PersonelPrim personelPrim) => Create(personelPrim);
        public void DeleteOnePersonelPrim(PersonelPrim personelPrim) => Update(personelPrim);
        public async Task<List<PersonelPrim>> GetAllPersonelPrimsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
        public async Task<PagedList<PersonelPrim>> GetAllPersonelPrimsAsync(PersonelPrimParameters personelPrimParameters, bool trackChanges)
        {
            var personelPrim = await FindAll(trackChanges)
             .FilterPersonelPrims(personelPrimParameters.PrimTuruId, personelPrimParameters.PersonelId, personelPrimParameters.Aktif)
             .Sort(personelPrimParameters.OrderBy)
             .ToListAsync();

            return PagedList<PersonelPrim>
                .ToPagedList(personelPrim,
                personelPrimParameters.PageNumber,
                personelPrimParameters.PageSize);
        }
        public async Task<PersonelPrim> GetOnePersonelPrimByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        public void UpdateOnePersonelPrim(PersonelPrim personelPrim) => Update(personelPrim);
    }
}
