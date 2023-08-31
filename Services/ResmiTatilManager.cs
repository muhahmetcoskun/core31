using AutoMapper;
using Entities.DataTransferObjects.ResmiTatil;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Contracts;
using Services.Contracts;
using System.Dynamic;

namespace Services
{
    public class ResmiTatilManager : IResmiTatilService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly IDataShaper<ResmiTatilDto> _shaper;

        public ResmiTatilManager(IRepositoryManager manager,
            ILoggerService logger,
            IMapper mapper,
            IDataShaper<ResmiTatilDto> shaper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
            _shaper = shaper;
        }

        public async Task<ResmiTatilDto> CreateOneResmiTatilAsync(ResmiTatilDtoForInsertion resmiTatilDto)
        {
            if (resmiTatilDto.Id > 0) throw new IdSubmitException(resmiTatilDto.Id);
            var entity = _mapper.Map<ResmiTatil>(resmiTatilDto);
            _manager.ResmiTatil.CreateOneResmiTatil(entity);
            await _manager.SaveAsync();
            return _mapper.Map<ResmiTatilDto>(entity);
        }

        public async Task DeleteOneResmiTatilAsync(int id, bool trackChanges)
        {
            var entity = await GetOneResmiTatilByIdAndCheckExists(id, trackChanges);
            entity.Aktif = false;
            _manager.ResmiTatil.DeleteOneResmiTatil(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<ExpandoObject> resmiTatils, MetaData metaData)> GetAllResmiTatilsAsync(ResmiTatilParameters resmiTatilParameters,
            bool trackChanges)
        {
            var resmiTatilMetaData = await _manager
                .ResmiTatil
                .GetAllResmiTatilsAsync(resmiTatilParameters, trackChanges);
             
            var resmiTatilDto = _mapper.Map<IEnumerable<ResmiTatilDto>>(resmiTatilMetaData);
            var shapedData = _shaper.ShapeData(resmiTatilDto, resmiTatilParameters.Fields);

            return (resmiTatils: shapedData, metaData: resmiTatilMetaData.MetaData);
        }
        
        public async Task<List<ResmiTatil>> GetAllResmiTatilsAsync(bool trackChanges)
        {
            var resmiTatils = await _manager.ResmiTatil.GetAllResmiTatilsAsync(trackChanges);
            return resmiTatils;
        }

        public async Task<ResmiTatilDto> GetOneResmiTatilByIdAsync(int id, bool trackChanges)
        {
            var resmiTatil =  await GetOneResmiTatilByIdAndCheckExists(id,trackChanges);
            return _mapper.Map<ResmiTatilDto>(resmiTatil);
        }

        public async Task UpdateOneResmiTatilAsync(int id, ResmiTatilDtoForUpdate resmiTatilDto, bool trackChanges)
        {
            var entity = await GetOneResmiTatilByIdAndCheckExists(id, trackChanges);
            entity = _mapper.Map<ResmiTatil>(resmiTatilDto);
            _manager.ResmiTatil.Update(entity);
            await _manager.SaveAsync();
        }

        private async Task<ResmiTatil> GetOneResmiTatilByIdAndCheckExists(int id, bool trackChanges)
        {
            // check entity 
            var entity = await _manager.ResmiTatil.GetOneResmiTatilByIdAsync(id, trackChanges);
            if (entity is null)
                throw new ResmiTatilNotFoundException(id);

            return entity;
        }

    }
}
