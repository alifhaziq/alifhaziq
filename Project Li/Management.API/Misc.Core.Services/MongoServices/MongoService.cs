using AutoMapper;
using Misc.Core.Domains.MongoDomains;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Core.Services.MongoServices
{
    public class MongoService : IMongoService
    {
        private readonly IMongoCollection<Course> CourseCol;

        public MongoService(IMongoClient Client)
        {

            var database = Client.GetDatabase("managementAPI");
            this.CourseCol = database.GetCollection<Course>("course");
        }

        public async Task<Course> AddCourse(Course model)
        {
            await CourseCol.InsertOneAsync(model);
            return model;
        }

        public async void DeleteCourse(string Id)
        {
            await CourseCol.DeleteOneAsync(x => x.Id == Id);
            
        }

        public async Task<Course> GetCourse(string Id)
        {
            var obj = await CourseCol.Find(x => x.Id == Id).FirstOrDefaultAsync();
            return obj != null ? obj : null;
            
        }

        public async Task<IEnumerable<Course>> GetCourse()
        {
            var obj = await CourseCol.Find(x => true).ToListAsync();
            return obj;
        }

        public async Task<Course> UpdateCourse(Course model)
        {
            var obj = await CourseCol.ReplaceOneAsync(x => x.Id == model.Id, model);
            return model;
        }
    }
}
