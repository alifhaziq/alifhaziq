using Misc.Core.Domains.PostgresDomains;
using Misc.Core.Domains.PostgresDomains.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Core.Services.PostgresServices
{
    public interface IPostgresRepo
    {
        //Department Service
        Task<Department> AddDepartment(Department model);
        Task<Department> GetDepartment(int Id);
        Task<IEnumerable<Department>> GetDepartment();
        Task<Department> UpdateDepartment(Department model);
        Task<Department> DeleteDepartment(Department model);

        //User Service
        Task<User> AddUser(User model);
        Task<User> GetUser(int Id);
        Task<IEnumerable<User>> GetUsers();
        Task<User> UpdateUser(User model);
        Task<User> DeleteUser(User model);
        Task<User> Authenticate(AuthUserDto model);
    }
}
