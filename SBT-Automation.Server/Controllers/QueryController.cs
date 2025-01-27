using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SBT_Automation.Data.Models;
using SBT_Automation.Server.Interfaces;

namespace SBT_Automation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        private readonly IQueryServices _queryServices;

        public QueryController(IQueryServices queryServices)
        {
            _queryServices = queryServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQueries()
        {
            var response = await _queryServices.GetAllQueries();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQueryById(string id)
        {
            var response = await _queryServices.GetQueryById(id);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuery([FromBody] QueryModel query)
        {
            var response = await _queryServices.CreateQuery(query);
            if (response.Success)
            {
                return CreatedAtAction(nameof(GetQueryById), new { id = query.Id }, response);
            }
            return BadRequest(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuery(string id, [FromBody] QueryModel query)
        {
            var response = await _queryServices.UpdateQuery(id, query);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuery(string id)
        {
            var response = await _queryServices.DeleteQuery(id);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}
