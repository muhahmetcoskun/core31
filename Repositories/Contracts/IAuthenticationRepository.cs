using Entities.Models;
using Entities.Models.MSSQLEntities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IAuthenticationRepository
    { 
        Task<List<UserRole>> GetAllAuthenticationAsync(bool trackChanges);
    }
}
