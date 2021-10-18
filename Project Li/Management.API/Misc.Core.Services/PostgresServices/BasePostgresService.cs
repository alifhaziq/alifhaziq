using Microsoft.EntityFrameworkCore;
using Misc.Core.Domains.PostgresDomains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Core.Services.PostgresServices
{
    public class BasePostgresService
    {
        private readonly PostgresDbContext dbContext;

        public BasePostgresService(PostgresDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<T> Query<T>() where T : BaseClass
        {
            return this.dbContext.Set<T>().AsQueryable();
        }

        public async Task<T> GetById<T>(int Id) where T : BaseClass
        {
            var obj = await this.dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == Id);
            return obj != null ? obj : null; 
        }

        public async Task<T> Create<T>(T model) where T : BaseClass
        {
            var obj = await this.dbContext.Set<T>().AddAsync(model);
            await this.dbContext.SaveChangesAsync();
            return obj.Entity;
        }

        public async Task<T> Update<T>(T model) where T : BaseClass
        {
            model.UpdatedAt = DateTime.Now;
            var obj = this.dbContext.Set<T>().Update(model);
            await this.dbContext.SaveChangesAsync();

            return obj.Entity;
        }

        public async Task<T> Delete<T>(T model) where T : BaseClass
        {
            var obj = this.dbContext.Set<T>().Remove(model);
            await this.dbContext.SaveChangesAsync();

            return obj.Entity;
        }
    }
}
