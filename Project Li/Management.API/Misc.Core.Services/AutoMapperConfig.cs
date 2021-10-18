using AutoMapper;
using Misc.Core.Domains.MongoDomains;
using Misc.Core.Domains.MongoDomains.Dtos;
using Misc.Core.Domains.PostgresDomains;
using Misc.Core.Domains.PostgresDomains.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Core.Services
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Department, UpsertDepartmentDto>().ReverseMap();
            CreateMap<User, UpsertUserDto>().ReverseMap();
            CreateMap<Course, UpsertCourseDto>().ReverseMap();

        }
    }
}
