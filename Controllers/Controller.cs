using Microsoft.AspNetCore.Mvc;
namespace PrimeiroExercicioAPI.Controllers
{
    [ApiController]
    [Route("MinhaController")]

    public class PrimeiroController : ControllerBase
    {
        [HttpGet("ApiSoma")]
        public IActionResult ApiDeSoma(double num1, double num2)
        {
            if (num1 > 999 || num2 > 999)
            {
               return BadRequest("Numero muito grande para conta");                       
            }else if (num1 == 0 || num2 == 0) 
            {
                return BadRequest("O valor não pode ser 0");     
            }

            return Ok(num1 + num2);               
        }

        [HttpGet("ApiSubtracao")]
        public IActionResult ApiDeSubtracao(double num1, double num2)
        {
            if (num1 > 999 || num2 > 999)
            {
               return BadRequest("Numero muito grande para conta");                       
            }else if (num1 == 0 || num2 == 0) 
            {
                return BadRequest("O valor não pode ser 0");     
            }

            return Ok(num1 - num2);               
        }
        [HttpGet("ApiMultiplicacao")]
        public IActionResult ApiDeMultiplicacao(double num1, double num2)
        {
            if (num1 > 999 || num2 > 999)
            {
               return BadRequest("Numero muito grande para conta");                       
            }else if (num1 == 0 || num2 == 0) 
            {
                return BadRequest("O valor não pode ser 0");     
            }

            return Ok(num1 * num2);               
        }
        [HttpGet("ApiDivisao")]
        public IActionResult ApiDeDivisao(double num1, double num2)
        {
            if (num1 > 999 || num2 > 999)
            {
               return BadRequest("Numero muito grande para conta");                       
            }else if (num1 == 0 || num2 == 0) 
            {
                return BadRequest("O valor não pode ser 0");     
            }

            return Ok(num1 / num2);               
        }
      
    }
}