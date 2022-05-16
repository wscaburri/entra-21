using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio15
    {
        public void Executar()
        {
            //15. Solicite ao usuário um texto e utilizando o while apresente caracter por caracter.

            Console.Write("Texto: ");
            string texto = Console.ReadLine();
            int indice = 0;

            while (indice < texto.Length)
            {
                string caracter = texto.Substring(0, 1);
                Console.WriteLine(caracter);
                                
                indice = indice + 1;
            }
        }
    }
}
