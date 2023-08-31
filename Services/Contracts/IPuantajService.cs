using Entities.DataTransferObjects.Puantaj;
using Entities.Models;
using Entities.Models.MSSQLEntities;
using Entities.RequestFeatures;
using System.Dynamic;

namespace Services.Contracts
{
    public interface IPuantajService
    {
        Task<(IEnumerable<ExpandoObject> puantajs, MetaData metaData)> GetAllPuantajsAsync(PuantajParameters puantajParameters, bool trackChanges);
        Task<PuantajDto> GetOnePuantajByIdAsync(int id, bool trackChanges);
        Task<PuantajDto> CreateOnePuantajAsync(PuantajDtoForInsertion puantaj);
        Task UpdateOnePuantajAsync(int id, PuantajDtoForUpdate puantajDto, bool trackChanges);
        Task DeleteOnePuantajAsync(int id, bool trackChanges);
        Task<(PuantajDtoForUpdate puantajDtoForUpdate, Puantaj puantaj)> GetOnePuantajForPatchAsync(int id, bool trackChanges);
        Task<MemoryStream> PuantajCizelgesiReportAsync(PuantajParameters puantajParameters);
        Task SaveChangesForPatchAsync(PuantajDtoForUpdate puantajDtoForUpdate, Puantaj puantaj);
        Task<List<Puantaj>> GetAllPuantajsAsync(bool trackChanges);
    }
}
