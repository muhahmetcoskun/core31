using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.DataTransferObjects.PrimTuru;
using Entities.Models;
using Entities.RequestFeatures;
using System.Dynamic;

namespace Services.Contracts
{
    public interface IPrimTuruService
    {
        Task<(IEnumerable<ExpandoObject> primTurus, MetaData metaData)> GetAllPrimTurusAsync(PrimTuruParameters primTuruParameters, bool trackChanges);
        Task<PrimTuruDto> GetOnePrimTuruByIdAsync(int id, bool trackChanges);
        Task<PrimTuruDto> CreateOnePrimTuruAsync(PrimTuruDtoForInsertion primTuru);
        Task UpdateOnePrimTuruAsync(int id, PrimTuruDtoForUpdate primTurulDto, bool trackChanges);
        Task DeleteOnePrimTuruAsync(int id, bool trackChanges);
        Task<List<PrimTuru>> GetAllPrimTurusAsync(bool trackChanges);
    }
}
