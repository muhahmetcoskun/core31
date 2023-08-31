using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.DataTransferObjects.CalismaGrubu;
using Entities.Models;
using Entities.RequestFeatures;
using System.Dynamic;
using Entities.Models.MSSQLEntities;

namespace Services.Contracts
{
    public interface ICalismaGrubuService
    {
        Task<(IEnumerable<ExpandoObject> calismaGrubus, MetaData metaData)> GetAllCalismaGrubusAsync(CalismaGrubuParameters calismaGrubuParameters, bool trackChanges);
        Task<CalismaGrubuDto> GetOneCalismaGrubuByIdAsync(int id, bool trackChanges);
        Task<CalismaGrubuDto> CreateOneCalismaGrubuAsync(CalismaGrubuDtoForInsertion personelPrim);
        Task UpdateOneCalismaGrubuAsync(int id, CalismaGrubuDtoForUpdate calismaGrubuDto, bool trackChanges);
        Task DeleteOneCalismaGrubuAsync(int id, bool trackChanges);
        Task<List<CalismaGrubu>> GetAllCalismaGrubusAsync(bool trackChanges);
        Task<List<Admin>> GetAllAdminsAsync(bool trackChanges);
        Task<Admin> GetOneAdminByIdAsync(int id, bool trackChanges);
    }
}
