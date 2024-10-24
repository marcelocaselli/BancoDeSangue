using BancoDeSangue.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeSangue.API.Controllers
{
    [ApiController]
    [Route("api/enderecos")]
    public class EnderecosController : ControllerBase
    {

        //Post api/enderecos
        [HttpPost]
        public IActionResult Post(CreateEnderecoInputModel model)
        {
            return NoContent();
        }

        //Put api/enderecos/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateEnderecoInputModel model)
        {
            return NoContent();
        }

        //Delete api/enderecos/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
