using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            Temperatura temperatura = new Temperatura();

            Console.Write("Informe uma Temperatura: ");
            temperatura.ValorTemperatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("1 = Celsius" +
                "\n2 = Fahrenheit" +
                "\n3 = Kelvin");              
            Console.Write("Converter de: ");
            temperatura.TemperaturaOrigem = Convert.ToDouble(Console.ReadLine());
            Console.Write("Para: ");
            temperatura.TemperaturaDestino = Convert.ToDouble(Console.ReadLine());

            temperatura.ApresentarTemperaturaConvertida();            
        }
    }
}
