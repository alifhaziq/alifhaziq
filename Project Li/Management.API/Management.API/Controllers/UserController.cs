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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPostgresRepo postgresRepo;
        private readonly IMapper mapper;
        public UserController(IPostgresRepo postgresRepo, IMapper mapper)
        {
            this.postgresRepo = postgresRepo;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        [ProducesResponseType(200, Type = typeof(User))]
        public async Task<IActionResult> AuthUser(AuthUserDto model)
        {
            try
            {
                var user = await postgresRepo.Authenticate(model);
                return Ok(user);
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }

        [HttpGet("[action]")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await postgresRepo.GetUsers();
                return users != null ? Ok(users) : NotFound();
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }

        [HttpGet("[action]/{Id}")]
        [ProducesResponseType(200, Type = typeof(User))]
        public async Task<IActionResult> GetUser(int Id)
        {
            try
            {
                var user = await postgresRepo.GetUser(Id);
                return user != null ? Ok(user) : NotFound();
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }

        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        [ProducesResponseType(200, Type = typeof(UpsertUserDto))]
        public async Task<IActionResult> AddUser(UpsertUserDto model)
        {
            try
            {
                if (model == null || !(ModelState.IsValid))
                {
                    return BadRequest();
                }

                var obj = mapper.Map<User>(model);
                var user = await postgresRepo.AddUser(obj);
                return CreatedAtAction(nameof(GetUser), new { Id = user.Id }, user);
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }

        }

        [HttpPut("[action]/{Id}")]
        [ProducesResponseType(200, Type = typeof(UpsertUserDto))]
        public async Task<IActionResult> UpdateUser(int Id, UpsertUserDto model)
        {
            try
            {
                if (model == null || !(ModelState.IsValid))
                {
                    return BadRequest();
                }

                var User = await postgresRepo.GetUser(Id);

                if (User == null)
                {
                    return NotFound();
                }

                var userObj = mapper.Map<UpsertUserDto, User>(model, User);
                var newUser = await postgresRepo.UpdateUser(userObj);

                return Ok(newUser);
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }

        [HttpDelete("[action]/{Id}")]
        [ProducesResponseType(200, Type = typeof(UpsertUserDto))]
        public async Task<IActionResult> DeleteUser(int Id)
        {
            try
            {
                var user = await postgresRepo.GetUser(Id); 

                if (user == null)
                {
                    return NotFound();
                }

                var objDeleted = await postgresRepo.DeleteUser(user);

                return Ok(objDeleted);
            }
            catch (Exception err)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, err.Message);
            }
        }

    }
}
