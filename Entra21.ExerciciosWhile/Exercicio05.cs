using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            //5. Faça um programa que solicite a quantidade de carros que o usuário deseja cadastrar,
            //após isto solicite para o usuário o modelo, valor e ano do carro até que atinja
            //a quantidade de carros para cadastro.
            //Apresente ao final:
            //● Média do ano dos carros;
            //● Média do valor dos carros;
            //● Quantidade de carros que começam com a letra G;
            //● Quantidade de carros que começam com a letra A.

            Console.Write("Digite a quantidade de carros que deseja cadastrar: ");
            int quantidadeCarrosCadastrados = Convert.ToInt32(Console.ReadLine());
            int somaAnoFabricacao = 0;
            int indice = 0;
            double somaValorCarro = 0;
            int quantidadeCarrosLetraG = 0;
            int quantidadeCarrosLetraA = 0;

            while (indice < quantidadeCarrosCadastrados)
            {
                Console.Write("Informe o modelo do carro: ");
                string modeloCarro = Console.ReadLine();

                Console.Write("Informe o valor do carro: R$");
                double valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe o ano de fabricação do carro: ");
                int anoFabricacao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (modeloCarro.ToLower().Trim().StartsWith("g"))
                {
                    quantidadeCarrosLetraG = quantidadeCarrosLetraG + 1;
                }

                if (modeloCarro.ToLower().Trim().StartsWith("a"))
                {
                    quantidadeCarrosLetraA = quantidadeCarrosLetraA + 1;
                }

                somaValorCarro = somaValorCarro + valorCarro;
                somaAnoFabricacao = somaAnoFabricacao + anoFabricacao;
                indice = indice + 1;
            }

            double mediaValorCarro = somaValorCarro / quantidadeCarrosCadastrados;
            double mediaAnoFabricacao = somaAnoFabricacao / quantidadeCarrosCadastrados;

            Console.WriteLine("A média do valor dos carro é: R$" + mediaValorCarro);
            Console.WriteLine("A média do ano de fabricação dos carros é: R$" + mediaAnoFabricacao);
            Console.WriteLine("A quantidade de carros que começa com a letra G é: " + quantidadeCarrosLetraG);
            Console.WriteLine("A quantidade de carros que começa com a letra A é: " + quantidadeCarrosLetraA);

        }
    }
}
