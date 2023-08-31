using AutoMapper;
using Entities.DataTransferObjects.GunlukCalismaSuresi;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Contracts;
using Services.Contracts;
using System.Dynamic;

namespace Services
{
    public class GunlukCalismaSuresiManager : IGunlukCalismaSuresiService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly IDataShaper<GunlukCalismaSuresiDto> _shaper;

        public GunlukCalismaSuresiManager(IRepositoryManager manager,
            ILoggerService logger,
            IMapper mapper,
            IDataShaper<GunlukCalismaSuresiDto> shaper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
            _shaper = shaper;
        }

        public async Task<GunlukCalismaSuresiDto> CreateOneGunlukCalismaSuresiAsync(GunlukCalismaSuresiDtoForInsertion gunlukCalismaSuresiDto)
        {
            var entity = _mapper.Map<GunlukCalismaSuresi>(gunlukCalismaSuresiDto);
            _manager.GunlukCalismaSuresi.CreateOneGunlukCalismaSuresi(entity);
            await _manager.SaveAsync();
            return _mapper.Map<GunlukCalismaSuresiDto>(entity);
        }

        public async Task DeleteOneGunlukCalismaSuresiAsync(int id, bool trackChanges)
        {
            var entity = await GetOneGunlukCalismaSuresiByIdAndCheckExists(id, trackChanges);
            entity.Aktif = false;
            _manager.GunlukCalismaSuresi.DeleteOneGunlukCalismaSuresi(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<ExpandoObject> gunlukCalismaSuresies, MetaData metaData)> GetAllGunlukCalismaSuresiesAsync(GunlukCalismaSuresiParameters gunlukCalismaSuresiParameters,bool trackChanges)
        {
            var gunlukCalismaSuresiMetaData = await _manager
                .GunlukCalismaSuresi
                .GetAllGunlukCalismaSuresisAsync(gunlukCalismaSuresiParameters, trackChanges);
             
            var gunlukCalismaSuresiDto = _mapper.Map<IEnumerable<GunlukCalismaSuresiDto>>(gunlukCalismaSuresiMetaData);
            var shapedData = _shaper.ShapeData(gunlukCalismaSuresiDto, gunlukCalismaSuresiParameters.Fields);

            return (gunlukCalismaSuresis: shapedData, metaData: gunlukCalismaSuresiMetaData.MetaData);
        }
        
        public async Task<List<GunlukCalismaSuresi>> GetAllGunlukCalismaSuresiesAsync(bool trackChanges)
        {
            var gunlukCalismaSuresis = await _manager.GunlukCalismaSuresi.GetAllGunlukCalismaSuresisAsync(trackChanges);
            return gunlukCalismaSuresis;
        }
 
        public async Task<GunlukCalismaSuresiDto> GetOneGunlukCalismaSuresiByIdAsync(int id, bool trackChanges)
        {
            var gunlukCalismaSuresi =  await GetOneGunlukCalismaSuresiByIdAndCheckExists(id,trackChanges);
            return _mapper.Map<GunlukCalismaSuresiDto>(gunlukCalismaSuresi);
        }

        public async Task UpdateOneGunlukCalismaSuresiAsync(int id, GunlukCalismaSuresiDtoForUpdate gunlukCalismaSuresiDto, bool trackChanges)
        {
            var entity = await GetOneGunlukCalismaSuresiByIdAndCheckExists(id, trackChanges);
            entity = _mapper.Map<GunlukCalismaSuresi>(gunlukCalismaSuresiDto);
            _manager.GunlukCalismaSuresi.Update(entity);
            await _manager.SaveAsync();
        }

        private async Task<GunlukCalismaSuresi> GetOneGunlukCalismaSuresiByIdAndCheckExists(int id, bool trackChanges)
        {
            // check entity 
            var entity = await _manager.GunlukCalismaSuresi.GetOneGunlukCalismaSuresiByIdAsync(id, trackChanges);
            if (entity is null)
                throw new GunlukCalismaSuresiNotFoundException(id);

            return entity;
        }

    }
}
