using Entities.Models;
using Entities.RequestFeatures;

namespace Repositories.Contracts
{
    public interface IUygulamaYetkiRepository : IRepositoryBase<UygulamaYetki>
    {
        Task<PagedList<UygulamaYetki>> GetAllUygulamaYetkiesAsync(UygulamaYetkiParameters uygulamaYetkiParameters,bool trackChanges);
        Task<List<UygulamaYetki>> GetAllUygulamaYetkiesAsync(bool trackChanges);
        Task<UygulamaYetki> GetOneUygulamaYetkiByIdAsync(int id, bool trackChanges);
        void CreateOneUygulamaYetki(UygulamaYetki UygulamaYetki);
        void UpdateOneUygulamaYetki(UygulamaYetki UygulamaYetki);
        void DeleteOneUygulamaYetki(UygulamaYetki UygulamaYetki);
        Task<IEnumerable<UygulamaYetki>> GetAllUygulamaYetkiesWithDetailsAsync(bool trackChanges);

    }
}
