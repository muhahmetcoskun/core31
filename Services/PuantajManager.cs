using AutoMapper;
using Entities.DataTransferObjects.Puantaj;
using Entities.Exceptions;
using Entities.Models;
using Entities.Models.MSSQLEntities;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using NLog.Filters;
using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;
using System.Dynamic;

namespace Services
{
    public class PuantajManager : IPuantajService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly IDataShaper<PuantajDto> _shaper;

        public PuantajManager(IRepositoryManager manager,
            ILoggerService logger,
            IMapper mapper,
            IDataShaper<PuantajDto> shaper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
            _shaper = shaper;
        }

        public async Task<PuantajDto> CreateOnePuantajAsync(PuantajDtoForInsertion puantajDto)
        {
            var entity = _mapper.Map<Puantaj>(puantajDto);
            _manager.Puantaj.CreateOnePuantaj(entity);
            await _manager.SaveAsync();

            return _mapper.Map<PuantajDto>(entity);
        }

        public async Task DeleteOnePuantajAsync(int id, bool trackChanges)
        {
            var entity = await GetOnePuantajByIdAndCheckExists(id, trackChanges);
            _manager.Puantaj.DeleteOnePuantaj(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<ExpandoObject> puantajs, MetaData metaData)>GetAllPuantajsAsync(PuantajParameters puantajParameters,
            bool trackChanges)
        { 
            var puantajsWithMetaData = await _manager
                .Puantaj
                .GetAllPuantajsAsync(puantajParameters, trackChanges);

            var puantajsDto = _mapper.Map<IEnumerable<PuantajDto>>(puantajsWithMetaData);
            var shapedData = _shaper.ShapeData(puantajsDto, puantajParameters.Fields);

            return (puantajs: shapedData, metaData: puantajsWithMetaData.MetaData);
        }

        public async Task<List<Puantaj>> GetAllPuantajsAsync(bool trackChanges)
        {
            var puantajs = await _manager.Puantaj.GetAllPuantajsAsync(trackChanges);
            return puantajs;
        }

        public async Task<PuantajDto> GetOnePuantajByIdAsync(int id, bool trackChanges)
        {
            var puantaj = await GetOnePuantajByIdAndCheckExists(id, trackChanges);
            return _mapper.Map<PuantajDto>(puantaj);
        }

        public async Task<(PuantajDtoForUpdate puantajDtoForUpdate, Puantaj puantaj)>
            GetOnePuantajForPatchAsync(int id, bool trackChanges)
        {
            var puantaj = await GetOnePuantajByIdAndCheckExists(id, trackChanges);
            var puantajDtoForUpdate = _mapper.Map<PuantajDtoForUpdate>(puantaj);
            return (puantajDtoForUpdate, puantaj);
        }

        public async Task<MemoryStream> PuantajCizelgesiReportAsync(PuantajParameters puantajParameters)
        {
            var ms = await _manager.Puantaj.PuantajCizelgesiReportAsync(puantajParameters);
            return ms;
        }

        public async Task SaveChangesForPatchAsync(PuantajDtoForUpdate puantajDtoForUpdate, Puantaj puantaj)
        {
            _mapper.Map(puantajDtoForUpdate, puantaj);
            await _manager.SaveAsync();
        }

        public async Task UpdateOnePuantajAsync(int id,
            PuantajDtoForUpdate puantajDto,
            bool trackChanges)
        {
            var entity = await GetOnePuantajByIdAndCheckExists(id, trackChanges);
            entity = _mapper.Map<Puantaj>(puantajDto);
            _manager.Puantaj.Update(entity);
            await _manager.SaveAsync();
        }

        private async Task<Puantaj> GetOnePuantajByIdAndCheckExists(int id, bool trackChanges)
        {
            // check entity 
            var entity = await _manager.Puantaj.GetOnePuantajByIdAsync(id, trackChanges);

            if (entity is null)
                throw new PuantajNotFoundException(id);

            return entity;
        }
    }
}
