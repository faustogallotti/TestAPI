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
    [Route("api/Multiplication")]
    [Produces("application/json")]
    public class MultiplicationController : Controller
    {
        private IMultiplicationService MultiplicationService { get; set; }

        public MultiplicationController(IMultiplicationService multiplicationService)
        {
            MultiplicationService = multiplicationService;
        }

        // GET: api/Multiply/5/4
        [HttpGet("{value1}/{value2}")]
        public IActionResult Multiply([FromRoute] int value1, [FromRoute] int value2)
        {
            ResultModel Response = new ResultModel
            {
                Value = MultiplicationService.Multiply(value1, value2)
            };

            return Ok(Response);
        }
    }
}
