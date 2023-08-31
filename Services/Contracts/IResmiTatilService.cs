using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.DataTransferObjects.ResmiTatil;
using Entities.Models;
using Entities.RequestFeatures;
using System.Dynamic;

namespace Services.Contracts
{
    public interface IResmiTatilService
    {
        Task<(IEnumerable<ExpandoObject> resmiTatils, MetaData metaData)> GetAllResmiTatilsAsync(ResmiTatilParameters resmiTatilParameters, bool trackChanges);
        Task<ResmiTatilDto> GetOneResmiTatilByIdAsync(int id, bool trackChanges);
        Task<ResmiTatilDto> CreateOneResmiTatilAsync(ResmiTatilDtoForInsertion resmiTatil);
        Task UpdateOneResmiTatilAsync(int id, ResmiTatilDtoForUpdate resmiTatilDto, bool trackChanges);
        Task DeleteOneResmiTatilAsync(int id, bool trackChanges);
        Task<List<ResmiTatil>> GetAllResmiTatilsAsync(bool trackChanges);
    }
}
