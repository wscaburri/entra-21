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
            Console.WriteLine("1 = Calcular Celsius para Kelvin" +
                "\n2 = Calcular Celsius para Fahrenheit" +
                "\n3 = Calcular Kelvin para Celsius" +
                "\n4 = Calcular Kelvin para Fahrenheit" +
                "\n5 = Calcular Fahrenheit para Celsius" +
                "\n6 = Calcular Fahrenheit para Kelvin");
            Console.Write("Informe a conversão: ");
        }
    }
}
