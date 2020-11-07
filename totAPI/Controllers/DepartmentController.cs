﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using totAPI.Data;
using totAPI.Models;
using totAPI.Models.Dtos;

namespace totAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(400)]
    public class DepartmentController : ControllerBase
    {
        private readonly ApplicationDBContext _db;
        private readonly IMapper _mapper;

        public DepartmentController(ApplicationDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet(Name = nameof(GetAll))]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Department>))]
        [ProducesResponseType(404)]
        public IActionResult GetAll()
        {
            IEnumerable<Department> obj = _db.Departments.OrderBy(x => x.Name).ToList();

            if(obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        [HttpGet("{departmentId:int}", Name = nameof(GetDepartment))]
        [ProducesResponseType(200, Type = typeof(Department))]
        [ProducesResponseType(404)]
        public IActionResult GetDepartment(int departmentId)
        {
            var obj = _db.Departments.FirstOrDefault(x => x.Id == departmentId);

            if(obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        [HttpPost(Name = nameof(CreateDepartment))]
        [ProducesResponseType(201, Type = typeof(Department))]
        public IActionResult CreateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            bool isExists = _db.Departments.Any(x => x.Name.ToLower().Trim() == createDepartmentDto.Name.ToLower().Trim());

            if(createDepartmentDto == null)
            {
                return BadRequest();
            }

            if (isExists)
            {
                ModelState.AddModelError("", "Department name is exists");
                return StatusCode(400, ModelState);
            }

            var obj = _mapper.Map<Department>(createDepartmentDto);

            _db.Departments.Add(obj);
            _db.SaveChanges();

            return CreatedAtRoute(nameof(GetDepartment), new { departmentId = obj.Id }, obj);
        } 

        [HttpPatch(Name = nameof(UpdateDepartment))]
        [ProducesResponseType(204, Type = typeof(Department))]
        public IActionResult UpdateDepartment(int departmentId, Department department)
        {
            bool isExists = _db.Departments.Any(x => x.Name.ToLower().Trim() == department.Name.ToLower().Trim());

            if (department == null && department.Id != departmentId)
            {
                return BadRequest();
            }

            if (isExists)
            {
                ModelState.AddModelError("", "Department name is exists");
                return StatusCode(400, ModelState);
            }

            _db.Departments.Update(department);
            _db.SaveChanges();

            return NoContent();

        }

        [HttpDelete(Name = nameof(DeleteDepartment))]
        [ProducesResponseType(204, Type = typeof(Department))]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public IActionResult DeleteDepartment(int id) {

            var obj = _db.Departments.FirstOrDefault(x => x.Id == id);

            if(obj.Id != id)
            {
                return NotFound();
            }

            _db.Departments.Remove(obj);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
