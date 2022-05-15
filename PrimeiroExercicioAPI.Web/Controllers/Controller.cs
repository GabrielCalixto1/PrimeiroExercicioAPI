using Microsoft.AspNetCore.Mvc;
using PrimeiroExercicioAPI.Models;
namespace PrimeiroExercicioAPI.Controllers
{
    [ApiController]
    [Route("MinhaController")]

    public class PrimeiroController : ControllerBase
    {
        [HttpGet("Somar")]
        public IActionResult ApiDeSoma(double num1, double num2)
        {
            try
            {
                var calculadora = new Calculadora();
                var resultado = calculadora.Somar(num1, num2);
                return Ok(resultado);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ApiSubtracao")]
        public IActionResult ApiDeSubtracao(double num1, double num2)
        {
            try
            {
                var calculadora = new Calculadora();
                var resultado = calculadora.Somar(num1, num2);
                return Ok(resultado);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("ApiMultiplicacao")]
        public IActionResult ApiDeMultiplicacao(double num1, double num2)
       {
            try
            {
                var calculadora = new Calculadora();
                var resultado = calculadora.Somar(num1, num2);
                return Ok(resultado);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("ApiDivisao")]
        public IActionResult ApiDeDivisao(double num1, double num2)
    {
            try
            {
                var calculadora = new Calculadora();
                var resultado = calculadora.Somar(num1, num2);
                return Ok(resultado);
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}