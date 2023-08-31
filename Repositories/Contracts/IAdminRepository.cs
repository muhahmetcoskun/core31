using Entities.Models;
using Entities.Models.MSSQLEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IAdminRepository
    {
        Task<Admin> GetOneAdminByIdAsync(int id, bool trackChanges);
        Task<List<Admin>> GetAllAdminsAsync(bool trackChanges);
    }
}
