using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Misc.Core.Domains;
using Misc.Core.Domains.PostgresDomains;
using Misc.Core.Domains.PostgresDomains.Dtos;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Utility = Misc.Core.Domains.Utility;

namespace Misc.Core.Services.PostgresServices
{
    public class PostgresRepo : IPostgresRepo
    {
        private readonly BasePostgresService postgresService;
        public PostgresRepo(BasePostgresService postgresService)
        {
            this.postgresService = postgresService;
        }

        #region department side
        public async Task<Department> AddDepartment(Department model)
        {
            var department = await postgresService.Create<Department>(model);
            return department;
        }

        public async Task<Department> DeleteDepartment(Department model)
        {
            var department = await postgresService.Delete<Department>(model);
            return department;
        }

        public async Task<Department> GetDepartment(int Id)
        {
            var department = await postgresService.GetById<Department>(Id);
            return department;
        }

        public async Task<IEnumerable<Department>> GetDepartment()      
        {
            var departments = await postgresService.Query<Department>().ToListAsync();
            return departments;
        }

        public async Task<Department> UpdateDepartment(Department model)
        {
            var department = await postgresService.Update<Department>(model);
            return department;
        }

        #endregion

        #region User Side
        public async Task<User> AddUser(User model)
        {
            model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);

            var user = await postgresService.Create<User>(model);
            return user;
        }

        public async Task<User> DeleteUser(User model)
        {
            var users = await postgresService.Delete<User>(model);
            return users;
        }

        public async Task<User> GetUser(int Id)
        {
            var user = await postgresService.GetById<User>(Id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await postgresService.Query<User>().ToListAsync();
            return users;
        }

        public async Task<User> UpdateUser(User model)
        {
            var user = await postgresService.Update<User>(model);
            return user;
        }

        public async Task<User> Authenticate(AuthUserDto model)
        {
            var user = await postgresService.Query<User>().SingleOrDefaultAsync(x => x.Email == model.Email);
            bool isvalidPassword = BCrypt.Net.BCrypt.Verify(model.Password, user.Password);

            if (isvalidPassword)
            {
                //generate Token 
                var tokenHandler = new JwtSecurityTokenHandler();
                var secretBytes = Encoding.UTF8.GetBytes(Utility.key);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.Id.ToString()),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.GivenName, user.Name),
                        new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                        new Claim(ClaimTypes.DateOfBirth, user.DOB.ToString())
                    }),

                    Expires = DateTime.Now.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretBytes), SecurityAlgorithms.HmacSha256)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);

                user.Token = tokenHandler.WriteToken(token);

                return user;
            }

            return null;
        }

        #endregion
    }
}
