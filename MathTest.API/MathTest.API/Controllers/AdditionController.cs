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
    [Route("api/Addition")]
    [Produces("application/json")]
    public class AdditionController : Controller
    {
        private IAdditionService AdditionService { get; set; }

        public AdditionController(IAdditionService additionService)
        {
            AdditionService = additionService;
        }

        // GET: api/Addition/5/4
        [HttpGet("{value1}/{value2}")]
        public IActionResult Sum([FromRoute]int value1, [FromRoute]int value2)
        {
            ResultModel Response = new ResultModel
            {
                Value = AdditionService.Sum(value1, value2)
            };

            return Ok(Response);
        }
    }
}
