using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorWebApi.Models;
using CalculatorWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebApi.Controllers
{
    [Route("api/math")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private IOperatorService _service;

        public MathController(IOperatorService service)
        {
            _service = service;
        }

        [HttpPost, Route("add")]
        public ActionResult<double> Add([FromBody] Calculate model)
        {
            var res = _service.Add(model);
            return Ok(res);
        }

        [HttpPost, Route("sub")]
        public ActionResult<double> Substract([FromBody] Calculate model)
        {
            var res = _service.Substract(model);
            return Ok(res);
        }

        [HttpPost, Route("div")]
        public ActionResult<double> Divide([FromBody] Calculate model)
        {
            var res = _service.Divide(model);
            return Ok(res);
        }

        [HttpPost, Route("mul")]
        public ActionResult<double> Multiply([FromBody] Calculate model)
        {
            var res = _service.Multiply(model);
            return Ok(res);
        }
    }
}