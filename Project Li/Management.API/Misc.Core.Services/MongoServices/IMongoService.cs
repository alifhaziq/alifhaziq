using Misc.Core.Domains.MongoDomains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Core.Services.MongoServices
{
    public interface IMongoService
    {
        Task<Course> AddCourse(Course model);
        Task<Course> GetCourse(string Id);
        Task<IEnumerable<Course>> GetCourse();
        Task<Course> UpdateCourse(Course model);
        void DeleteCourse(string Id);
    }
}
