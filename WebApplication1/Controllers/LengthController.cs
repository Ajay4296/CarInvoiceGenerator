using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class LengthController : Controller
    {
        private ILengthManager lengthConvertor;

        public LengthController(ILengthManager length)
        {
            this.lengthConvertor = length;
        }

        [Route("api/InchToFeet")]
        [HttpGet]
        public async Task<IActionResult> GetFeet(double inch)
        {
            var result = lengthConvertor.IncheToFeet(inch);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }

        [Route("api/FeetToInch")]
        [HttpGet]
        public async Task<IActionResult> GetInch(double feet)
        {
            var result = lengthConvertor.FeetToInche(feet);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
    }
}
