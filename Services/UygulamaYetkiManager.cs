using AutoMapper;
using Entities.DataTransferObjects.UygulamaYetki;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Contracts;
using Services.Contracts;
using System.Dynamic;

namespace Services
{
    public class UygulamaYetkiManager : IUygulamaYetkiService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly IDataShaper<UygulamaYetkiDto> _shaper;

        public UygulamaYetkiManager(IRepositoryManager manager,
            ILoggerService logger,
            IMapper mapper,
            IDataShaper<UygulamaYetkiDto> shaper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
            _shaper = shaper;
        }

        public async Task<UygulamaYetkiDto> CreateOneUygulamaYetkiAsync(UygulamaYetkiDtoForInsertion uygulamaYetkiDto)
        {
            var entity = _mapper.Map<UygulamaYetki>(uygulamaYetkiDto);
            _manager.UygulamaYetki.CreateOneUygulamaYetki(entity);
            await _manager.SaveAsync();
            return _mapper.Map<UygulamaYetkiDto>(entity);
        }

        public async Task DeleteOneUygulamaYetkiAsync(int id, bool trackChanges)
        {
            var entity = await GetOneUygulamaYetkiByIdAndCheckExists(id, trackChanges);
            entity.Aktif = false;
            _manager.UygulamaYetki.DeleteOneUygulamaYetki(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<ExpandoObject> uygulamaYetkies, MetaData metaData)> GetAllUygulamaYetkiesAsync(UygulamaYetkiParameters uygulamaYetkiParameters,bool trackChanges)
        {
            var uygulamaYetkiesMetaData = await _manager
                .UygulamaYetki
                .GetAllUygulamaYetkiesAsync(uygulamaYetkiParameters, trackChanges);
             
            var uygulamaYetkiDto = _mapper.Map<IEnumerable<UygulamaYetkiDto>>(uygulamaYetkiesMetaData);
            var shapedData = _shaper.ShapeData(uygulamaYetkiDto, uygulamaYetkiParameters.Fields);

            return (puantajVeriGirisies: shapedData, metaData: uygulamaYetkiesMetaData.MetaData);
        }
        
        public async Task<List<UygulamaYetki>> GetAllUygulamaYetkiesAsync(bool trackChanges)
        {
            var uygulamaYetkies = await _manager.UygulamaYetki.GetAllUygulamaYetkiesAsync(trackChanges);
            return uygulamaYetkies;
        }

        public async Task<UygulamaYetkiDto> GetOneUygulamaYetkiByIdAsync(int id, bool trackChanges)
        {
            var uygulamaYetki =  await GetOneUygulamaYetkiByIdAndCheckExists(id,trackChanges);
            return _mapper.Map<UygulamaYetkiDto>(uygulamaYetki);
        }

        public async Task UpdateOneUygulamaYetkiAsync(int id, UygulamaYetkiDtoForUpdate uygulamaYetkiDto, bool trackChanges)
        {
            var entity = await GetOneUygulamaYetkiByIdAndCheckExists(id, trackChanges);
            entity = _mapper.Map<UygulamaYetki>(uygulamaYetkiDto);
            _manager.UygulamaYetki.Update(entity);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<UygulamaYetki>> GetAllUygulamaYetkiesWithDetailsAsync(bool trackChanges)
        {
            return await _manager
                .UygulamaYetki
                .GetAllUygulamaYetkiesWithDetailsAsync(trackChanges);
        }

        private async Task<UygulamaYetki> GetOneUygulamaYetkiByIdAndCheckExists(int id, bool trackChanges)
        {
            // check entity 
            var entity = await _manager.UygulamaYetki.GetOneUygulamaYetkiByIdAsync(id, trackChanges);
            if (entity is null)
                throw new UygulamaYetkiNotFoundException(id);

            return entity;
        }
 
    }
}
