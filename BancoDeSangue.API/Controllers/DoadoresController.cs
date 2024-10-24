using Microsoft.AspNetCore.Mvc;
using BancoDeSangue.Application;
using BancoDeSangue.Application.Models;

namespace BancoDeSangue.API.Controllers
{
    [ApiController]
    [Route("api/doadores")]
    public class DoadoresController : ControllerBase
    {
        //Get api/doadores?search=xyz
        [HttpGet]
        public IActionResult Get(DoadorViewModel model, string search = "")
        {
            return Ok();
        }

        //GetById api/doadores/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //Post api/doadores
        [HttpPost]
        public IActionResult Post(CreateDoadorInputModel model)
        {
            return NoContent();
        }

        [HttpPut("{id}/doacoes")]
        public IActionResult PostDoacoes(DoadoresDoacoesInputModel model)
        {
            return NoContent();
        }

        //Put api/doadores/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateDoadorInputModel model)
        {
            return NoContent();
        }

        //Delete api/doadores/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
