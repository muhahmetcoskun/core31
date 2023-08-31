using Microsoft.EntityFrameworkCore.Storage;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {

        private readonly RepositoryContext _context;
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPuantajVeriGirisiRepository _puantajVeriGirisiRepository;
        private readonly IPuantajRepository _puantajRepository;
        private readonly IUygulamaYetkiRepository _uygulamaYetkiRepository;
        private readonly IResmiTatilRepository _resmiTatilRepository;
        private readonly IPrimTuruRepository _primTuruRepository;
        private readonly IPersonelPrimRepository _personelPrimRepository;
        private readonly IGunlukCalismaSuresiRepository _gunlukCalismaSuresiRepository;
        private readonly ICalismaGrubuRepository _calismaGrubuRepository;
        private readonly IAuthenticationRepository _authenticationRepository;

        public RepositoryManager(RepositoryContext context,
            IBookRepository bookRepository,
            ICategoryRepository categoryRepository, 
            IPuantajVeriGirisiRepository puantajVeriGirisiRepository,
            IPuantajRepository puantajRepository,
            IUygulamaYetkiRepository uygulamaYetkiRepository,
            IResmiTatilRepository resmiTatilRepository,
            IPrimTuruRepository primTuruRepository,
            IPersonelPrimRepository personelPrimRepository,
            IGunlukCalismaSuresiRepository gunlukCalismaSuresiRepository,
            ICalismaGrubuRepository calismaGrubuRepository,
            IAuthenticationRepository authenticationRepository)
        {
            _context = context;
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
            _puantajVeriGirisiRepository = puantajVeriGirisiRepository;
            _puantajRepository = puantajRepository;
            _uygulamaYetkiRepository = uygulamaYetkiRepository;
            _resmiTatilRepository = resmiTatilRepository;
            _primTuruRepository = primTuruRepository;
            _gunlukCalismaSuresiRepository = gunlukCalismaSuresiRepository;
            _personelPrimRepository = personelPrimRepository;
            _calismaGrubuRepository = calismaGrubuRepository;
            _authenticationRepository = authenticationRepository;   
        }

        public IBookRepository Book => _bookRepository;
        public ICategoryRepository Category => _categoryRepository;
        public IPuantajVeriGirisiRepository PuantajVeriGirisi => _puantajVeriGirisiRepository;
        public IPuantajRepository Puantaj => _puantajRepository;
        public IUygulamaYetkiRepository UygulamaYetki => _uygulamaYetkiRepository;
        public IAuthenticationRepository Authentication => _authenticationRepository;
        public IResmiTatilRepository ResmiTatil => _resmiTatilRepository;
        public IPrimTuruRepository PrimTuru => _primTuruRepository;
        public IPersonelPrimRepository PersonelPrim => _personelPrimRepository;
        public IGunlukCalismaSuresiRepository GunlukCalismaSuresi => _gunlukCalismaSuresiRepository;
        public ICalismaGrubuRepository CalismaGrubu => _calismaGrubuRepository;
        public IDbContextTransaction BeginTransaction() => _context.Database.BeginTransaction();
        public void Commit() => BeginTransaction().Commit();
        public void Rollback() => BeginTransaction().Rollback();

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
