using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.Models;
using Entities.RequestFeatures;
using System.Dynamic;

namespace Services.Contracts
{
    public interface IPuantajVeriGirisiService
    {

        Task<(IEnumerable<ExpandoObject> puantajVeriGirisis, MetaData metaData)> GetAllPuantajVeriGirisisAsync(PuantajVeriGirisiParameters puantajVeriGirisiParameters, bool trackChanges);
        Task<PuantajVeriGirisiDto> GetOnePuantajVeriGirisiByIdAsync(int id, bool trackChanges);
        Task<PuantajVeriGirisiDto> CreateOnePuantajVeriGirisiAsync(PuantajVeriGirisiDtoForInsertion puantajVeriGirisi);
        Task UpdateOnePuantajVeriGirisiAsync(int id, PuantajVeriGirisiDtoForUpdate puantajVeriGirisiDto, bool trackChanges);
        Task DeleteOnePuantajVeriGirisiAsync(int id, bool trackChanges);
        Task<List<PuantajVeriGirisi>> GetAllPuantajVeriGirisisAsync(bool trackChanges);
        Task<IEnumerable<PuantajVeriGirisi>> GetAllPuantajVeriGirisiesWithDetailsAsync(bool trackChanges);
    }
}
