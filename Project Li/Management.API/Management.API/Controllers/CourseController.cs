using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Misc.Core.Domains.MongoDomains;
using Misc.Core.Domains.MongoDomains.Dtos;
using Misc.Core.Services.MongoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly IMongoService mongoService;
        private readonly IMapper mapper;
        public CourseController(IMongoService mongoService, IMapper mapper)
        {
            this.mongoService = mongoService;
            this.mapper = mapper;
        }

        [HttpGet("[action]")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Course>))]
        public async Task<IActionResult> GetCourses()
        {
            try 
            {
                var courses = await mongoService.GetCourse();
                return courses != null ? Ok(courses) : NotFound();
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }

        [HttpGet("[action]/{Id}")]
        [ProducesResponseType(200, Type = typeof(Course))]
        public async Task<IActionResult> GetCourse(string Id)
        {
            try
            {
                var course = await mongoService.GetCourse(Id);
                return course != null ? Ok(course) : NotFound();
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }

        }

        [HttpPost("[action]")]
        [ProducesResponseType(200, Type = typeof(UpsertCourseDto))]
        public async Task<IActionResult> AddCourse(UpsertCourseDto model)
        {
            try
            {
                if (model == null || !(ModelState.IsValid))
                {
                    return BadRequest();
                }

                var obj = mapper.Map<Course>(model);
                var course = await mongoService.AddCourse(obj);
                return CreatedAtAction(nameof(GetCourse), new { Id = course.Id }, course);
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }

        }

        [HttpPut("[action]/{Id}")]
        [ProducesResponseType(200, Type = typeof(UpsertCourseDto))]
        public async Task<IActionResult> UpdateCourse(string Id, UpsertCourseDto model)
        {
            try
            {
                if (model == null || !(ModelState.IsValid))
                {
                    return BadRequest();
                }

                var course = await mongoService.GetCourse(Id);

                if (course == null)
                {
                    return NotFound();
                }

                var courseObj = mapper.Map<UpsertCourseDto, Course>(model, course);
                var newCourse = await mongoService.UpdateCourse(courseObj);

                return Ok(newCourse);
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }

        [HttpDelete("[action]/{Id}")]
        [ProducesResponseType(200, Type = typeof(UpsertCourseDto))]
        public async Task<IActionResult> DeleteCourse(string Id)
        {
            try
            {
                var course = await mongoService.GetCourse(Id);

                if (course == null)
                {
                    return NotFound();
                }

                mongoService.DeleteCourse(Id);
                return Ok();
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }
    }
}
