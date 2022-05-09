using Microsoft.AspNetCore.Mvc;
namespace PrimeiroExercicioAPI.Models
{
    public class Calculadora : Controller
    {
        public IActionResult Somar(double num1, double num2)
        {
            if (num1 > 999 || num2 > 999)
            {
                return BadRequest("Numero muito grande para conta");
            }
            else if (num1 == 0 || num2 == 0)
            {
                return BadRequest("O valor não pode ser 0");
            }

            return Ok(num1 + num2);
        }
        public IActionResult Subtrair(double num1, double num2)
        {
            if (num1 > 999 || num2 > 999)
            {
                return BadRequest("Numero muito grande para conta");
            }
            else if (num1 == 0 || num2 == 0)
            {
                return BadRequest("O valor não pode ser 0");
            }

            return Ok(num1 - num2);
        }
        public IActionResult Multiplicar(double num1, double num2)
        {
            if (num1 > 999 || num2 > 999)
            {
                return BadRequest("Numero muito grande para conta");
            }
            else if (num1 == 0 || num2 == 0)
            {
                return BadRequest("O valor não pode ser 0");
            }
            else if (num1 < 0 || num2 < 0)
            {
                return BadRequest("O valor não pode ser menor que 0");
            }


            return Ok(num1 * num2);
        }
        public IActionResult Dividir(double num1, double num2)
        {
            if (num1 > 999 || num2 > 999)
            {
                return BadRequest("Numero muito grande para conta");
            }
            else if (num1 == 0 || num2 == 0)
            {
                return BadRequest("O valor não pode ser 0");
            }
            else if (num1 < 0 || num2 < 0)
            {
                return BadRequest("O valor não pode ser menor que 0");
            }

            return Ok(num1 / num2);
        }
    }
}
