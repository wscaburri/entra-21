using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            //1. Solicite o preço e nome da peça de 13 peças

            int indice = 0;

            while (indice < 13)
            {
                Console.Write("Digite o nome da peça: ");
                string nomePeca = Console.ReadLine();
                Console.Write("Digite o valor da peça: ");
                double valorPeca = Convert.ToDouble(Console.ReadLine());
                indice = indice + 1;
            }

        }
    }
}
