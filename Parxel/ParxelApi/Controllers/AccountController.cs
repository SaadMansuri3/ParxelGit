using Architecture.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParxelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly DeveloperDbContext _dbContext;

        public AccountController(DeveloperDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var users = await _dbContext.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(User user)
        {
            User registerUser = new User();
            registerUser.Id = Guid.NewGuid();
            registerUser.FirstName = user.FirstName;
            registerUser.LastName = user.LastName;
            registerUser.DOB = user.DOB;
            registerUser.CountryCode = user.CountryCode;
            registerUser.Mobile = user.Mobile;

            await _dbContext.Users.AddAsync(registerUser);
            await _dbContext.SaveChangesAsync();

            return Ok(registerUser);
        }
    }
}
