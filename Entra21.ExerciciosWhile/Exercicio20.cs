using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio20
    {
        public void Executar()
        {
            //8.Solicite um número e apresentar a tabuada do mesmo até 1000.

            var numeroValido = false;

            while (numeroValido == false)
            {
                try
                {
                    Console.Write("Informe um número: ");
                    var numero = Convert.ToDouble(Console.ReadLine());

                    for (var i = 0; i <= 1000; i++)
                    {
                        Console.WriteLine(numero + " X " + i + " = " + (numero * i));
                    }

                    numeroValido = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opção Inválida. Tente novamente com um número válido!");
                }
            }
        }
    }
}
