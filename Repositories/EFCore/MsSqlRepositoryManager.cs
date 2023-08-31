using Microsoft.EntityFrameworkCore.Storage;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class MsSqlRepositoryManager : IMsSqlRepositoryManager
    {

        private readonly EmployeeContext _msSqlContext;
        private readonly IAdminRepository _adminRepository;

        public MsSqlRepositoryManager(EmployeeContext msSqlContext,
            IAdminRepository adminRepository)
        {
            _msSqlContext = msSqlContext;
            _adminRepository = adminRepository;
        }

        public IAdminRepository Admin => _adminRepository;

        public IDbContextTransaction BeginTransaction() => _msSqlContext.Database.BeginTransaction();
        public void Commit() => BeginTransaction().Commit();
        public void Rollback() => BeginTransaction().Rollback();

        public async Task SaveAsync()
        {
            await _msSqlContext.SaveChangesAsync();
        }
    }
}
