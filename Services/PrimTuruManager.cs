using AutoMapper;
using Entities.DataTransferObjects.PrimTuru;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Contracts;
using Services.Contracts;
using System.Dynamic;

namespace Services
{
    public class PrimTuruManager : IPrimTuruService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly IDataShaper<PrimTuruDto> _shaper;

        public PrimTuruManager(IRepositoryManager manager,
            ILoggerService logger,
            IMapper mapper,
            IDataShaper<PrimTuruDto> shaper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
            _shaper = shaper;
        }

        public async Task<PrimTuruDto> CreateOnePrimTuruAsync(PrimTuruDtoForInsertion primTuruDto)
        {
            var entity = _mapper.Map<PrimTuru>(primTuruDto);
            _manager.PrimTuru.CreateOnePrimTuru(entity);
            await _manager.SaveAsync();
            return _mapper.Map<PrimTuruDto>(entity);
        }

        public async Task DeleteOnePrimTuruAsync(int id, bool trackChanges)
        {
            var entity = await GetOnePrimTuruByIdAndCheckExists(id, trackChanges);
            entity.Aktif = false;
            _manager.PrimTuru.DeleteOnePrimTuru(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<ExpandoObject> primTurus, MetaData metaData)> GetAllPrimTurusAsync(PrimTuruParameters primTuruParameters,bool trackChanges)
        {
            var primTuruMetaData = await _manager
                .PrimTuru
                .GetAllPrimTurusAsync(primTuruParameters, trackChanges);
             
            var primTuruDto = _mapper.Map<IEnumerable<PrimTuruDto>>(primTuruMetaData);
            var shapedData = _shaper.ShapeData(primTuruDto, primTuruParameters.Fields);

            return (primTurus: shapedData, metaData: primTuruMetaData.MetaData);
        }
        
        public async Task<List<PrimTuru>> GetAllPrimTurusAsync(bool trackChanges)
        {
            var primTurus = await _manager.PrimTuru.GetAllPrimTurusAsync(trackChanges);
            return primTurus;
        }
 
        public async Task<PrimTuruDto> GetOnePrimTuruByIdAsync(int id, bool trackChanges)
        {
            var primTuru =  await GetOnePrimTuruByIdAndCheckExists(id,trackChanges);
            return _mapper.Map<PrimTuruDto>(primTuru);
        }

        public async Task UpdateOnePrimTuruAsync(int id, PrimTuruDtoForUpdate primTuruDto, bool trackChanges)
        {
            var entity = await GetOnePrimTuruByIdAndCheckExists(id, trackChanges);
            entity = _mapper.Map<PrimTuru>(primTuruDto);
            _manager.PrimTuru.Update(entity);
            await _manager.SaveAsync();
        }

        private async Task<PrimTuru> GetOnePrimTuruByIdAndCheckExists(int id, bool trackChanges)
        {
            // check entity 
            var entity = await _manager.PrimTuru.GetOnePrimTuruByIdAsync(id, trackChanges);
            if (entity is null)
                throw new PrimTuruNotFoundException(id);

            return entity;
        }

    }
}
