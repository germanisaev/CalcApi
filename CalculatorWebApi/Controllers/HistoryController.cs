using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorWebApi.Models;
using CalculatorWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalculatorWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private IHistoryService _historyService;

        public HistoryController(IHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var story = _historyService.GetAll();
            return Ok(story);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var story = _historyService.GetById(id);
            return Ok(story);
        }

        [HttpGet("user/{userId}")]
        public IActionResult GetByUser(int userId)
        {
            var story = _historyService.GetByUser(userId);
            return Ok(story);
        }

        [HttpPost]
        public IActionResult Create([FromBody] History model)
        {
            try
            {
                _historyService.Create(model);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] History model)
        {
            var story = _historyService.GetById(id);
            try
            {
                _historyService.Update(model.Id, story);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _historyService.Delete(id);
            return Ok();
        }

        //private bool HistoryExists(int id)
        //{
        //    return _historyService.Histories.Any(e => e.Id == id);
        //}
    }
}