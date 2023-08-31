using Entities.DataTransferObjects.UygulamaYetki;
using Entities.Models;
using Entities.Models.MSSQLEntities;
using Entities.RequestFeatures;
using FastReport;
using FastReport.Export.PdfSimple;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Repositories.Contracts;
using Repositories.EFCore.Extensions;
using System.Data;

namespace Repositories.EFCore
{
    public sealed class AuthenticationRepository : RepositoryBase<UserRole>, IAuthenticationRepository
    {
        public AuthenticationRepository(RepositoryContext context) : base(context)
        {
            
        }

        public async Task<List<UserRole>> GetAllAuthenticationAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(b => b.UserId)
                .ToListAsync(); 
        }
         
        
    }
}
