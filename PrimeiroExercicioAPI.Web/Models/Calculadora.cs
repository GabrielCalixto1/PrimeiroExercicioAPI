using PrimeiroExercicioAPI.Web.Controllers;
namespace PrimeiroExercicioAPI.Models
{
    public class Calculadora
    {
        public double Somar(double num1, double num2)
        {
            if (ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 + num2;
            }
            throw new InputIncorrect("Ocorreu um erro inesperado");
        }
        public double Substrair(double num1, double num2)
        {
            if (ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 - num2;
            }
            throw new InputIncorrect("Ocorreu um erro inesperado");
        }
        public double Dividir(double num1, double num2)
        {
            if (ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 / num2;
            }
            throw new InputIncorrect("Ocorreu um erro inesperado");
        }
        public double Multiplicar(double num1, double num2)
        {
            if (ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 * num2;
            }
            throw new InputIncorrect("Ocorreu um erro inesperado");
        }
        public bool ValidarNumero(double valor)
        {

            if (valor != 0 & valor < 1000)
                return true;
            return false;
        }
    }

}

