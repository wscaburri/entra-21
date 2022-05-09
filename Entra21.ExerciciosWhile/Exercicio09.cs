using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            //9. Solicite um número e faça o fatorial deste número, utilizando while.

            Console.Write("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int fatorial = numero - 1;

            while (fatorial < 0)
            {
                Console.WriteLine(numero * fatorial);
                fatorial = fatorial - 1;
            }
        }
    }
}
