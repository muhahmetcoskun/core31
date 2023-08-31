using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.DataTransferObjects.PersonelPrim;
using Entities.Models;
using Entities.RequestFeatures;
using System.Dynamic;
using Entities.Models.MSSQLEntities;

namespace Services.Contracts
{
    public interface IPersonelPrimService
    {
        Task<(IEnumerable<ExpandoObject> personelPrims, MetaData metaData)> GetAllPersonelPrimsAsync(PersonelPrimParameters personelPrimParameters, bool trackChanges);
        Task<PersonelPrimDto> GetOnePersonelPrimByIdAsync(int id, bool trackChanges);
        Task<PersonelPrimDto> CreateOnePersonelPrimAsync(PersonelPrimDtoForInsertion personelPrim);
        Task UpdateOnePersonelPrimAsync(int id, PersonelPrimDtoForUpdate personelPrimDto, bool trackChanges);
        Task DeleteOnePersonelPrimAsync(int id, bool trackChanges);
        Task<List<PersonelPrim>> GetAllPersonelPrimsAsync(bool trackChanges);
        Task<List<Admin>> GetAllAdminsAsync(bool trackChanges);
        Task<Admin> GetOneAdminByIdAsync(int id, bool trackChanges);
    }
}
