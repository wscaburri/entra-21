using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            //1. Crie um vetor para guardar 16 números inteiros.
            //Preencha todas as posições com números e apresente a soma destes números.

            int[] numerosInteiros = new int[16];

            for (int i = 0; i < numerosInteiros.Length; i = i + 1)
            {
                try
                {
                    Console.Write("Digite um número inteiro: ");
                    numerosInteiros[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    i--;
                }                
            }

            int somaNumeros = 0;

            for (int i = 0; i < numerosInteiros.Length; i = i + 1)
            {
                somaNumeros = somaNumeros + numerosInteiros[i];
            }

            Console.WriteLine("A soma de todos os números é: " + somaNumeros);
        }
    }
}
