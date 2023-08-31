using AutoMapper;
using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Contracts;
using Services.Contracts;
using System.Dynamic;

namespace Services
{
    public class PuantajVeriGirisiManager : IPuantajVeriGirisiService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly IDataShaper<PuantajVeriGirisiDto> _shaper;

        public PuantajVeriGirisiManager(IRepositoryManager manager,
            ILoggerService logger,
            IMapper mapper,
            IDataShaper<PuantajVeriGirisiDto> shaper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
            _shaper = shaper;
        }

        public async Task<PuantajVeriGirisiDto> CreateOnePuantajVeriGirisiAsync(PuantajVeriGirisiDtoForInsertion puantajVeriGirisiDto)
        {
            var entity = _mapper.Map<PuantajVeriGirisi>(puantajVeriGirisiDto);
            _manager.PuantajVeriGirisi.CreateOnePuantajVeriGirisi(entity);
            await _manager.SaveAsync();
            return _mapper.Map<PuantajVeriGirisiDto>(entity);
        }

        public async Task DeleteOnePuantajVeriGirisiAsync(int id, bool trackChanges)
        {
            var entity = await GetOnePuantajVeriGirisiByIdAndCheckExists(id, trackChanges);
            entity.Aktif = false;
            _manager.PuantajVeriGirisi.DeleteOnePuantajVeriGirisi(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<ExpandoObject> puantajVeriGirisis, MetaData metaData)> GetAllPuantajVeriGirisisAsync(PuantajVeriGirisiParameters puantajVeriGirisiParameters,
            bool trackChanges)
        {
            var puantajVeriGirisisMetaData = await _manager
                .PuantajVeriGirisi
                .GetAllPuantajVeriGirisisAsync(puantajVeriGirisiParameters, trackChanges);
             
            var puantajVeriGirisiDto = _mapper.Map<IEnumerable<PuantajVeriGirisiDto>>(puantajVeriGirisisMetaData);
            var shapedData = _shaper.ShapeData(puantajVeriGirisiDto, puantajVeriGirisiParameters.Fields);

            return (puantajVeriGirisies: shapedData, metaData: puantajVeriGirisisMetaData.MetaData);
        }

        public async Task<List<PuantajVeriGirisi>> GetAllPuantajVeriGirisisAsync(bool trackChanges)
        {
            var puantajVeriGirisies = await _manager.PuantajVeriGirisi.GetAllPuantajVeriGirisisAsync(trackChanges);
            return puantajVeriGirisies;
        }

        public async Task<PuantajVeriGirisiDto> GetOnePuantajVeriGirisiByIdAsync(int id, bool trackChanges)
        {
            var puantajVeriGirisi =  await GetOnePuantajVeriGirisiByIdAndCheckExists(id,trackChanges);
            return _mapper.Map<PuantajVeriGirisiDto>(puantajVeriGirisi);
        }

        public async Task UpdateOnePuantajVeriGirisiAsync(int id, PuantajVeriGirisiDtoForUpdate puantajVeriGirisiDto, bool trackChanges)
        {
            var entity = await GetOnePuantajVeriGirisiByIdAndCheckExists(id, trackChanges);
            entity = _mapper.Map<PuantajVeriGirisi>(puantajVeriGirisiDto);
            _manager.PuantajVeriGirisi.Update(entity);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<PuantajVeriGirisi>> GetAllPuantajVeriGirisiesWithDetailsAsync(bool trackChanges)
        {
            return await _manager
                .PuantajVeriGirisi
                .GetAllPuantajVeriGirisiesWithDetailsAsync(trackChanges);
        }

        private async Task<PuantajVeriGirisi> GetOnePuantajVeriGirisiByIdAndCheckExists(int id, bool trackChanges)
        {
            var entity = await _manager.PuantajVeriGirisi.GetOnePuantajVeriGirisiByIdAsync(id, trackChanges);
            if (entity is null)
                throw new PuantajVeriGirisiNotFoundException(id);

            return entity;
        }
    }
}
