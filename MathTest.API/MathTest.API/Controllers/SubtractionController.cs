using MathTest.API.Models;
using MathTest.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathTest.API.Controllers
{
    [AllowAnonymous]
    [Route("api/Subtraction")]
    [Produces("application/json")]
    public class SubtractionController : Controller
    {
        private ISubtractionService SubtractionService { get; set; }

        public SubtractionController(ISubtractionService subtractionService)
        {
            SubtractionService = subtractionService;
        }

        // GET: api/Subtraction/5/4
        [HttpGet("{value1}/{value2}")]
        public IActionResult Subtraction([FromRoute] int value1, [FromRoute] int value2)
        {
            ResultModel Response = new ResultModel
            {
                Value = SubtractionService.Subtraction(value1, value2)
            };

            return Ok(Response);
        }
    }
}
