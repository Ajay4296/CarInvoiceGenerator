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
    public class TempController : ControllerBase
    {
            public readonly ITempManager manager;

            /// <summary>
            /// Initializes a new instance of the <see cref="EmployeeController"/> class.
            /// </summary>
            /// <param name="manager">The manager.</param>
            public TempController(ITempManager manager)
            {
                this.manager = manager;
            }

            /// <summary>
            /// Converteds the farhenheith to celsius.
            /// </summary>
            /// <param name="F_value">The f value.</param>
            /// <returns></returns>
            [Route("api/Converted_FarhenheithToCelsius")]
            [HttpGet]
            public ActionResult<double> Converted_FarhenheithToCelsius(double F_value)
            {
                return manager.FarenhiteToCelcius(F_value);
            }

            /// <summary>
            /// Converteds the celsius to fahrenheith.
            /// </summary>
            /// <param name="C_value">The c value.</param>
            /// <returns></returns>
            [Route("api/Converted_CelsiusToFahrenheith")]
            [HttpGet]
            public ActionResult<double> Converted_CelsiusToFahrenheith(double C_value)
            {
                return manager.CelciusToFarenhite(C_value);
            }

        }
    }