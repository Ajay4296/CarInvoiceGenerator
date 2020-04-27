using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        private IWeightManager lengthConvertor;

        public WeightController(IWeightManager length)
        {
            this.lengthConvertor = length;
        }

        [Route("api/KgToGram")]
        [HttpGet]
        public async Task<IActionResult> GetGram(double kg)
        {
            var result = lengthConvertor.KgToGram(kg);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }

        [Route("api/GramToKg")]
        [HttpGet]
        public async Task<IActionResult> GetKilogram(double gm)
        {
            var result = lengthConvertor.GramToKg(gm);
            if (result != 0.0)
                return Ok(result);

            return this.BadRequest();
        }
    }
}