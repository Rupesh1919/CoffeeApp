using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeApp.Data;
using CoffeeApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private ExpressoDbContext _expressoDbContext;
        public RegistrationController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }
        [HttpPost]
        public IActionResult Post(Registration registration)
        {
            _expressoDbContext.Registrations.Add(registration);
            _expressoDbContext.SaveChanges();
            return StatusCode(statusCode: 201);
        }
    }
}