using Microsoft.AspNetCore.Mvc;
namespace PrimeiroExercicioAPI.Controllers
{
    [ApiController]
    [Route("MinhaController")]

    public class PrimeiroController : ControllerBase
    {
        [HttpGet("ApiSoma")]
        public double ApiDeSoma(double num1, double num2)
        {
            return num1 + num2;
        }
            [HttpGet("ApiSubtracao")]
        public double ApiDeSubtracao(double num1, double num2)
        {
            return num1 - num2;
        }
            [HttpGet("ApiMultiplicacao")]
        public double ApiDeMultiplicacao(double num1, double num2)
        {
            return num1 * num2;
        }
            [HttpGet("ApiDivisao")]
        public double ApiDeDivisao(double num1, double num2)
        {
            return num1 / num2;
        }
         
     




        [HttpGet("segundaApi")]
          public IActionResult ErroDeRequest(int entrada)
        {
            if(entrada == 1)
            {
                return BadRequest("1- Não é uma entrada válida");
            }
            return Ok(entrada);
        }
    }
}