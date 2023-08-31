using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Mvc;

namespace Repositories.Contracts
{
    public interface IPuantajRepository : IRepositoryBase<Puantaj>
    {
        Task<PagedList<Puantaj>> GetAllPuantajsAsync(PuantajParameters puantajVeriGirisiParameters,bool trackChanges);
        Task<List<Puantaj>> GetAllPuantajsAsync(bool trackChanges);
        Task<Puantaj> GetOnePuantajByIdAsync(int id, bool trackChanges);
        void CreateOnePuantaj(Puantaj puantajVeriGirisi);
        void UpdateOnePuantaj(Puantaj puantajVeriGirisi);
        void DeleteOnePuantaj(Puantaj puantajVeriGirisi);
        Task<MemoryStream> PuantajCizelgesiReportAsync(PuantajParameters puantajVeriGirisiParameters);
    }
}
