using AutoMapper;
using Entities.DataTransferObjects.CalismaGrubu;
using Entities.Exceptions;
using Entities.Models;
using Entities.Models.MSSQLEntities;
using Entities.RequestFeatures;
using Repositories.Contracts;
using Services.Contracts;
using System.Dynamic;

namespace Services
{
    public class CalismaGrubuManager : ICalismaGrubuService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMsSqlRepositoryManager _msSqlManager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly IDataShaper<CalismaGrubuDto> _shaper;

        public CalismaGrubuManager(IRepositoryManager manager,
             IMsSqlRepositoryManager msSqlManager,
            ILoggerService logger,
            IMapper mapper,
            IDataShaper<CalismaGrubuDto> shaper)
        {
            _manager = manager;
            _msSqlManager = msSqlManager;
            _logger = logger;
            _mapper = mapper;
            _shaper = shaper;
        }

        public async Task<CalismaGrubuDto> CreateOneCalismaGrubuAsync(CalismaGrubuDtoForInsertion calismaGrubuDto)
        {
            var entity = _mapper.Map<CalismaGrubu>(calismaGrubuDto);
            _manager.CalismaGrubu.CreateOneCalismaGrubu(entity);
            await _manager.SaveAsync();
            return _mapper.Map<CalismaGrubuDto>(entity);
        }

        public async Task DeleteOneCalismaGrubuAsync(int id, bool trackChanges)
        {
            var entity = await GetOneCalismaGrubuByIdAndCheckExists(id, trackChanges);
            entity.Aktif = false;
            _manager.CalismaGrubu.DeleteOneCalismaGrubu(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<ExpandoObject> calismaGrubus, MetaData metaData)> GetAllCalismaGrubusAsync(CalismaGrubuParameters calismaGrubuParameters, bool trackChanges)
        {
            var calismaGrubuMetaData = await _manager
                .CalismaGrubu
                .GetAllCalismaGrubusAsync(calismaGrubuParameters, trackChanges);
             
            var calismaGrubuDto = _mapper.Map<IEnumerable<CalismaGrubuDto>>(calismaGrubuMetaData);
            var shapedData = _shaper.ShapeData(calismaGrubuDto, calismaGrubuParameters.Fields);

            return (calismaGrubus: shapedData, metaData: calismaGrubuMetaData.MetaData);
        }
        
        public async Task<List<CalismaGrubu>> GetAllCalismaGrubusAsync(bool trackChanges)
        {
            var calismaGrubus = await _manager.CalismaGrubu.GetAllCalismaGrubusAsync(trackChanges);
            return calismaGrubus;
        }
 
        public async Task<CalismaGrubuDto> GetOneCalismaGrubuByIdAsync(int id, bool trackChanges)
        {
            var calismaGrubu =  await GetOneCalismaGrubuByIdAndCheckExists(id,trackChanges);
            return _mapper.Map<CalismaGrubuDto>(calismaGrubu);
        }

        public async Task UpdateOneCalismaGrubuAsync(int id, CalismaGrubuDtoForUpdate calismaGrubuDto, bool trackChanges)
        {
            var entity = await GetOneCalismaGrubuByIdAndCheckExists(id, trackChanges);
            entity = _mapper.Map<CalismaGrubu>(calismaGrubuDto);
            _manager.CalismaGrubu.Update(entity);
            await _manager.SaveAsync();
        }

        private async Task<CalismaGrubu> GetOneCalismaGrubuByIdAndCheckExists(int id, bool trackChanges)
        {
            // check entity 
            var entity = await _manager.CalismaGrubu.GetOneCalismaGrubuByIdAsync(id, trackChanges);
            if (entity is null)
                throw new CalismaGrubuNotFoundException(id);

            return entity;
        }

        public async Task<List<Admin>> GetAllAdminsAsync(bool trackChanges)
        {
            var admins = await _msSqlManager.Admin.GetAllAdminsAsync(trackChanges);
            return admins;
        }

        public async Task<Admin> GetOneAdminByIdAsync(int id, bool trackChanges)
        {
            var admin = await _msSqlManager.Admin.GetOneAdminByIdAsync(id, trackChanges);
            return admin;
        }
         
    }
}
