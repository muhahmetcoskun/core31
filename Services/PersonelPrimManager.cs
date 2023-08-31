using AutoMapper;
using Entities.DataTransferObjects.PersonelPrim;
using Entities.Exceptions;
using Entities.Models;
using Entities.Models.MSSQLEntities;
using Entities.RequestFeatures;
using Repositories.Contracts;
using Services.Contracts;
using System.Dynamic;

namespace Services
{
    public class PersonelPrimManager : IPersonelPrimService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMsSqlRepositoryManager _msSqlManager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly IDataShaper<PersonelPrimDto> _shaper;

        public PersonelPrimManager(IRepositoryManager manager,
             IMsSqlRepositoryManager msSqlManager,
            ILoggerService logger,
            IMapper mapper,
            IDataShaper<PersonelPrimDto> shaper)
        {
            _manager = manager;
            _msSqlManager = msSqlManager;
            _logger = logger;
            _mapper = mapper;
            _shaper = shaper;
        }

        public async Task<PersonelPrimDto> CreateOnePersonelPrimAsync(PersonelPrimDtoForInsertion personelPrimDto)
        {
            var entity = _mapper.Map<PersonelPrim>(personelPrimDto);
            _manager.PersonelPrim.CreateOnePersonelPrim(entity);
            await _manager.SaveAsync();
            return _mapper.Map<PersonelPrimDto>(entity);
        }

        public async Task DeleteOnePersonelPrimAsync(int id, bool trackChanges)
        {
            var entity = await GetOnePersonelPrimByIdAndCheckExists(id, trackChanges);
            entity.Aktif = false;
            _manager.PersonelPrim.DeleteOnePersonelPrim(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<ExpandoObject> personelPrims, MetaData metaData)> GetAllPersonelPrimsAsync(PersonelPrimParameters personelPrimParameters,bool trackChanges)
        {
            var personelPrimMetaData = await _manager
                .PersonelPrim
                .GetAllPersonelPrimsAsync(personelPrimParameters, trackChanges);
             
            var personelPrimDto = _mapper.Map<IEnumerable<PersonelPrimDto>>(personelPrimMetaData);
            var shapedData = _shaper.ShapeData(personelPrimDto, personelPrimParameters.Fields);

            return (personelPrims: shapedData, metaData: personelPrimMetaData.MetaData);
        }
        
        public async Task<List<PersonelPrim>> GetAllPersonelPrimsAsync(bool trackChanges)
        {
            var personelPrims = await _manager.PersonelPrim.GetAllPersonelPrimsAsync(trackChanges);
            return personelPrims;
        }
 
        public async Task<PersonelPrimDto> GetOnePersonelPrimByIdAsync(int id, bool trackChanges)
        {
            var personelPrim =  await GetOnePersonelPrimByIdAndCheckExists(id,trackChanges);
            return _mapper.Map<PersonelPrimDto>(personelPrim);
        }

        public async Task UpdateOnePersonelPrimAsync(int id, PersonelPrimDtoForUpdate personelPrimDto, bool trackChanges)
        {
            var entity = await GetOnePersonelPrimByIdAndCheckExists(id, trackChanges);
            entity = _mapper.Map<PersonelPrim>(personelPrimDto);
            _manager.PersonelPrim.Update(entity);
            await _manager.SaveAsync();
        }

        private async Task<PersonelPrim> GetOnePersonelPrimByIdAndCheckExists(int id, bool trackChanges)
        {
            // check entity 
            var entity = await _manager.PersonelPrim.GetOnePersonelPrimByIdAsync(id, trackChanges);
            if (entity is null)
                throw new PersonelPrimNotFoundException(id);

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
