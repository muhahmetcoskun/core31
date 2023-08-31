﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IServiceManager
    {
        IBookService BookService { get; }
        ICategoryService CategoryService { get; }
        IPuantajVeriGirisiService PuantajVeriGirisiService { get; }
        IPuantajService PuantajService { get; }
        IUygulamaYetkiService UygulamaYetkiService { get; }
        IResmiTatilService ResmiTatilService { get; }
        IPrimTuruService PrimTuruService { get; }
        IPersonelPrimService PersonelPrimService { get; }
        IGunlukCalismaSuresiService GunlukCalismaSuresiService { get; }
        ICalismaGrubuService CalismaGrubuService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
