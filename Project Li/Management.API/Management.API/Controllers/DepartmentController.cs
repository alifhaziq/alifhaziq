using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Misc.Core.Domains.PostgresDomains;
using Misc.Core.Domains.PostgresDomains.Dtos;
using Misc.Core.Services.PostgresServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IPostgresRepo postgresRepo;
        private readonly IMapper mapper;
        public DepartmentController(IPostgresRepo postgresRepo, IMapper mapper)
        {
            this.postgresRepo = postgresRepo;
            this.mapper = mapper;
        }

        [HttpGet("[action]")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Department>))]
        public async Task<IActionResult> GetDepartments()
        {
            try
            {
                var departments = await postgresRepo.GetDepartment();
                return departments != null ? Ok(departments) : NotFound();
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }

        [HttpGet("[action]/{Id}")]
        [ProducesResponseType(200, Type = typeof(Department))]
        public async Task<IActionResult> GetDepartment(int Id)
        {
            try
            {
                var department = await postgresRepo.GetDepartment(Id);
                return department != null ? Ok(department) : NotFound();
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }

        }

        [HttpPost("[action]")]
        [ProducesResponseType(200, Type = typeof(UpsertDepartmentDto))]
        public async Task<IActionResult> AddDepartment(UpsertDepartmentDto model)
        {
            try
            {
                if (model == null || !(ModelState.IsValid))
                {
                    return BadRequest();
                }

                var obj = mapper.Map<Department>(model);
                var department = await postgresRepo.AddDepartment(obj);
                return CreatedAtAction(nameof(GetDepartment), new { Id = department.Id }, department);
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }

        }

        [HttpPut("[action]/{Id}")]
        [ProducesResponseType(200, Type = typeof(UpsertDepartmentDto))]
        public async Task<IActionResult> UpdateDepartment(int Id, UpsertDepartmentDto model)
        {
            try
            {
                if (model == null || !(ModelState.IsValid))
                {
                    return BadRequest();
                }

                var department = await postgresRepo.GetDepartment(Id);

                if (department == null)
                {
                    return NotFound();
                }

                var departmentObj = mapper.Map<UpsertDepartmentDto, Department>(model, department);
                var newDepartment = await postgresRepo.UpdateDepartment(departmentObj);

                return Ok(newDepartment);
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }

        [HttpDelete("[action]/{Id}")]
        [ProducesResponseType(200, Type = typeof(UpsertDepartmentDto))]
        public async Task<IActionResult> DeleteDepartment(int Id)
        {
            try
            {
                var department = await postgresRepo.GetDepartment(Id);

                if (department == null)
                {
                    return NotFound();
                }

                var objDeleted = await postgresRepo.DeleteDepartment(department);

                return Ok(objDeleted);
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }

    }
}
