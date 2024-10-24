using BancoDeSangue.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeSangue.API.Controllers
{
    [ApiController]
    [Route("api/doacoes")]
    public class DoacoesController : ControllerBase
    {
        //Get api/doacoes
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        //Get api/doacoes/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //Post api/doacoes
        [HttpPost]
        public IActionResult Post(CreateDoacaoInputModel model)
        {
            return NoContent();
        }

        //Put api/doacoes/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateDoacaoInputModel model)
        {
            return NoContent();
        }

        //Delete api/doacoes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
