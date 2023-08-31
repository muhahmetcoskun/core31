using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IBookRepository Book { get; }
        ICategoryRepository Category { get; }
        IPuantajVeriGirisiRepository PuantajVeriGirisi { get; }
        IPuantajRepository Puantaj { get; }
        IUygulamaYetkiRepository UygulamaYetki { get; }
        IResmiTatilRepository ResmiTatil { get; }
        IPrimTuruRepository PrimTuru { get; }
        IPersonelPrimRepository PersonelPrim { get; }
        IGunlukCalismaSuresiRepository GunlukCalismaSuresi { get; }
        ICalismaGrubuRepository CalismaGrubu { get; }
        IAuthenticationRepository Authentication { get; }
        Task SaveAsync();
        void Commit();
        void Rollback();
        IDbContextTransaction BeginTransaction();
    }
}
