using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicios01
    {
        public void Executar()
        {
            //1. Crie um vetor para guardar 16 números inteiros.
            //Preencha todas as posições com números e apresente a soma destes números.

            int[] numerosInteiros = new int[2];  
            bool numeroValido = false;
            
            
            while(numeroValido == false)
            {                
                try
                {
                    for (int i = 0; i < numerosInteiros.Length; i = i + 1)
                    {
                        Console.Write("Digite um número inteiro: ");
                        numerosInteiros[i] = Convert.ToInt32(Console.ReadLine());

                        numeroValido = true;
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Esse número não é um inteiro válido, tente novamente.");
                    numeroValido = true;
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
