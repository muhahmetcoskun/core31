using Services.Contracts;


namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        private readonly IPuantajVeriGirisiService _puantajVeriGirisiService;
        private readonly IPuantajService _puantajService;
        private readonly IUygulamaYetkiService _uygulamaYetkiService;
        private readonly IResmiTatilService _resmiTatilService;
        private readonly IPrimTuruService _primTuruService;
        private readonly IPersonelPrimService _personelPrimService;
        private readonly IGunlukCalismaSuresiService _gunlukCalismaSuresiService;
        private readonly ICalismaGrubuService _calismaGrubuService;
        private readonly IAuthenticationService _authencationService;

        public ServiceManager(IBookService bookService,
            ICategoryService categoryService,
            IPuantajVeriGirisiService puantajVeriGirisiService, 
            IPuantajService puantajService,
            IUygulamaYetkiService uygulamaYetkiService,
            IResmiTatilService resmiTatilService,
            IPrimTuruService primTuruService, 
            IPersonelPrimService personelPrimService,
            IGunlukCalismaSuresiService gunlukCalismaSuresiService,
            ICalismaGrubuService calismaGrubuService, 
            IAuthenticationService authencationService)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            _puantajVeriGirisiService = puantajVeriGirisiService;
            _puantajService = puantajService;
            _uygulamaYetkiService = uygulamaYetkiService;
            _resmiTatilService = resmiTatilService;
            _primTuruService = primTuruService;
            _personelPrimService = personelPrimService;
            _gunlukCalismaSuresiService = gunlukCalismaSuresiService;
            _calismaGrubuService = calismaGrubuService;
            _authencationService = authencationService;
        }

        public IBookService BookService => _bookService;
        public ICategoryService CategoryService => _categoryService;
        public IAuthenticationService AuthenticationService => _authencationService;
        public IPuantajVeriGirisiService PuantajVeriGirisiService => _puantajVeriGirisiService;
        public IPuantajService PuantajService => _puantajService;
        public IUygulamaYetkiService UygulamaYetkiService => _uygulamaYetkiService;
        public IResmiTatilService ResmiTatilService => _resmiTatilService;
        public IPrimTuruService PrimTuruService => _primTuruService;
        public IPersonelPrimService PersonelPrimService => _personelPrimService;
        public IGunlukCalismaSuresiService GunlukCalismaSuresiService => _gunlukCalismaSuresiService;
        public ICalismaGrubuService CalismaGrubuService => _calismaGrubuService;
    }
}
