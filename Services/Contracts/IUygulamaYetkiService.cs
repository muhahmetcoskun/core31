using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.DataTransferObjects.UygulamaYetki;
using Entities.Models;
using Entities.RequestFeatures;
using System.Dynamic;

namespace Services.Contracts
{
    public interface IUygulamaYetkiService
    {
        Task<(IEnumerable<ExpandoObject> uygulamaYetkies, MetaData metaData)> GetAllUygulamaYetkiesAsync(UygulamaYetkiParameters uygulamaYetkiParameters, bool trackChanges);
        Task<UygulamaYetkiDto> GetOneUygulamaYetkiByIdAsync(int id, bool trackChanges);
        Task<UygulamaYetkiDto> CreateOneUygulamaYetkiAsync(UygulamaYetkiDtoForInsertion uygulamaYetki);
        Task UpdateOneUygulamaYetkiAsync(int id, UygulamaYetkiDtoForUpdate uygulamaYetkiDto, bool trackChanges);
        Task DeleteOneUygulamaYetkiAsync(int id, bool trackChanges);
        Task<List<UygulamaYetki>> GetAllUygulamaYetkiesAsync(bool trackChanges);
        Task<IEnumerable<UygulamaYetki>> GetAllUygulamaYetkiesWithDetailsAsync(bool trackChanges);
    }
}
