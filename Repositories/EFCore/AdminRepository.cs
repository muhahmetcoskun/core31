using Entities.Models;
using Entities.Models.MSSQLEntities;
using Entities.RequestFeatures;
using FastReport;
using FastReport.Export.PdfSimple;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;
using System.Data;

namespace Repositories.EFCore
{
    public sealed class AdminRepository : MsSqlRepositoryBase<Admin>, IAdminRepository
    {
        public AdminRepository(EmployeeContext context) : base(context)
        {
            
        }

        public async Task<List<Admin>> GetAllAdminsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(b => b.AdminId)
                .ToListAsync();
        }
        public async Task<Admin> GetOneAdminByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.AdminId.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        
    }
}
