using PrimeiroExercicioAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace PrimeiroExercicioAPI.Controllers
{
    public class ControllerDesafioExtra : Controller
    {
        [HttpGet("ApiCalculadora")]
        public IActionResult ApiDeSoma(double num1, double num2)
        {   
            var calc = new Calculadora();
            return calc.Somar(num1, num2);
        }
         public IActionResult ApiDeSubtracao(double num1, double num2)
        {   
            var calc = new Calculadora();
            return calc.Subtrair(num1, num2);
        }
         public IActionResult ApiDeMultiplicacao(double num1, double num2)
        {   
            var calc = new Calculadora();
            return calc.Multiplicar(num1, num2);
        }
         public IActionResult ApiDeDivisao(double num1, double num2)
        {   
            var calc = new Calculadora();
            return calc.Dividir(num1, num2);
        }
    }

}