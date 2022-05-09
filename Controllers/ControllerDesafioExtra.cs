using PrimeiroExercicioAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace PrimeiroExercicioAPI.Controllers
{
    public class ControllerDesafioExtra : Controller
    {
        [HttpGet("ApiCalculadora")]
        public IActionResult ApiDeCalculadora(double num1, double num2)
        {   
            var calc = new Calculadora();
            return calc.Somar(num1, num2);
        }
    }

}