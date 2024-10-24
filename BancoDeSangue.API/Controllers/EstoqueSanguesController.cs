using BancoDeSangue.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeSangue.API.Controllers
{
    [ApiController]
    [Route("api/estoquesangues")]
    public class EstoqueSanguesController : ControllerBase
    {
        //Get api/estoquesangues
        [HttpGet]
        public IActionResult Get(EstoqueSangueViewModel model)
        {
            return Ok();
        }

        //Get api/estoquesangues/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //Post api/estoquesangues
        [HttpPost]
        public IActionResult Post()
        {
            return NoContent();
        }

        //Put api/estoquesangues/id
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return NoContent();
        }

        //Delete api/estoquesangues/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
