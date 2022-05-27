using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    public class Temperatura
    {
        public double TemperaturaOrigem;
        public double TemperaturaDestino;
        public double ValorTemperatura;

        public void CalcularCelsiusParaKelvin()
        {
            ValorTemperatura = ValorTemperatura + 273.15;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " K");
        }

        public void CalcularCelsiusParaFahrenheit()
        {
            ValorTemperatura = (ValorTemperatura * 9 / 5) + 32;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " °F");
        }

        public void CalcularKelvinParaCelsius()
        {
            ValorTemperatura = ValorTemperatura - 273.15;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " °C");
        }

        public void CalcularKelvinParaFahrenheit()
        {
            ValorTemperatura = (ValorTemperatura - 273.15) * 9 / 5 + 32;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " °F");
        }

        public void CalcularFahrenheitParaCelsius()
        {
            ValorTemperatura = (ValorTemperatura - 32) * 5 / 9;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " °C");
        }

        public void CalcularFahrenheitParaKelvin()
        {
            ValorTemperatura = (ValorTemperatura - 32) * 5 / 9 + 273.15;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " K");
        }
    }
}
