using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IMsSqlRepositoryManager
    {
        IAdminRepository Admin { get; }
        Task SaveAsync();
        void Commit();
        void Rollback();
        IDbContextTransaction BeginTransaction();
    }
}
