using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteCartinhasDoPapaiNoel.Models;

namespace SiteCartinhasDoPapaiNoel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartinhaController : ControllerBase
    {
        private List<Cartinha> cartinhas = new List<Cartinha>();

        [HttpPost]
        public IActionResult EnviarCartinha([FromBody] Cartinha cartinha)
        {
            if (cartinha == null)
            {
                return BadRequest("A carta não pode estar vazia.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (cartinha.Idade > 15)
            {
                return BadRequest("O Papai Noel não atende crianças maiores de 15 anos.");
            }

            cartinhas.Add(cartinha);

            return Ok("Cartinha enviada com sucesso!");
        }

        [HttpGet]
        public IActionResult ListarCartinhas()
        {
            return Ok(cartinhas);
        }
    }
}
