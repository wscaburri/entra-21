using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio04
    {
        public void Executar()
        {
            //4. Solicite o peso para o usuário até que o peso seja menor que 0 ou maior que 300,00.
            //Apresentar ao final a quantidade de pessoas que informaram o peso.

            double peso = 0.01;
            int quantidadePessoas = 0;

            while ((peso >= 0) && (peso <= 300))
            {
                Console.Write("Digite seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                quantidadePessoas = quantidadePessoas + 1;
            }

            Console.WriteLine("Quantidade de Pessoas que informaram o peso: " + quantidadePessoas);
        }
    }
}
