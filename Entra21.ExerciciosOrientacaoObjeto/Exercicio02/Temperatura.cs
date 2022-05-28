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

        public double CalcularCelsiusParaKelvin()
        {
            ValorTemperatura = ValorTemperatura + 273.15;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " K");
            return ValorTemperatura;
        }

        public double CalcularCelsiusParaFahrenheit()
        {
            ValorTemperatura = (ValorTemperatura * 9 / 5) + 32;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " °F");
            return ValorTemperatura;
        }

        public double CalcularKelvinParaCelsius()
        {
            ValorTemperatura = ValorTemperatura - 273.15;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " °C");
            return ValorTemperatura;
        }

        public double CalcularKelvinParaFahrenheit()
        {
            ValorTemperatura = (ValorTemperatura - 273.15) * 9 / 5 + 32;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " °F");
            return ValorTemperatura;
        }

        public double CalcularFahrenheitParaCelsius()
        {
            ValorTemperatura = (ValorTemperatura - 32) * 5 / 9;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " °C");
            return ValorTemperatura;
        }

        public double CalcularFahrenheitParaKelvin()
        {
            ValorTemperatura = (ValorTemperatura - 32) * 5 / 9 + 273.15;
            Console.WriteLine("Temperatura é " + ValorTemperatura + " K");
            return ValorTemperatura;
        }

        public void ApresentarTemperaturaConvertida()
        {
            if (TemperaturaOrigem == 1 && TemperaturaDestino == 2)
            {
                CalcularCelsiusParaFahrenheit();
            }
            else if (TemperaturaOrigem == 1 && TemperaturaDestino == 3)
            {
                CalcularCelsiusParaKelvin();
            }
            else if (TemperaturaOrigem == 2 && TemperaturaDestino == 1)
            {
                CalcularFahrenheitParaCelsius();
            }
            else if (TemperaturaOrigem == 2 && TemperaturaDestino == 3)
            {
                CalcularFahrenheitParaKelvin();
            }
            else if (TemperaturaOrigem == 3 && TemperaturaDestino == 1)
            {
                CalcularKelvinParaCelsius();
            }
            else if (TemperaturaOrigem == 3 && TemperaturaDestino == 2)
            {
                CalcularKelvinParaFahrenheit();
            }
        }
    }
}
