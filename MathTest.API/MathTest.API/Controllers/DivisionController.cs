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
    [Route("api/Division")]
    [Produces("application/json")]
    public class DivisionController : Controller
    {
        private IDivisionService DivisionService { get; set; }

        public DivisionController(IDivisionService divisionService)
        {
            DivisionService = divisionService;
        }

        // GET: api/Division/5/4
        [HttpGet("{value1}/{value2}")]
        public IActionResult Sum([FromRoute] int value1, [FromRoute] int value2)
        {
            ResultModel Response = new ResultModel
            {
                Value = DivisionService.Divide(value1, value2)
            };

            return Ok(Response);
        }
    }
}
