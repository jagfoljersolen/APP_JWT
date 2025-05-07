using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace IS_lab8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrimeController : ControllerBase
    {
        private static readonly List<int> Primes = new List<int> { 2, 3, 5, 7, 11, 13 };

        [Authorize(Roles = "number", AuthenticationSchemes =
            JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("draw")]
        public IActionResult DrawPrime()
        {
            var random = new Random();
            int index = random.Next(Primes.Count);
            int drawnPrime = Primes[index];
            return Ok(new { prime = drawnPrime });
        }
    }
}