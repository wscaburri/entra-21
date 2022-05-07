using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            //8.Solicite um número e apresentar a tabuada do mesmo até 1000.

            int indice = 0, soma = 0;
            
            Console.Write("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (indice <= 1000)
            {
                soma = numero + indice;
                indice = indice + 1;
            }

            
        }
    }
}
