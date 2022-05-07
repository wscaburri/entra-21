using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            //7.Solicite o nome, valor, quantidade enquanto a quantidade de produtos for menor que 5.
            //Ao final deve - se aplicar um desconto de R$ 150,00.

            string nomeProduto = "";
            double valorProduto = 0, valorTotalCompra = 0;
            int quantidadeProduto = 0;
            int indice = 0;

            while (indice < 5)
            {
                Console.Write("Informe o nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Informe o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe a quantidade do produto: ");
                quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                if (quantidadeProduto >= 5)
                {
                    indice = 5;
                }

                valorTotalCompra = valorTotalCompra + (valorProduto * quantidadeProduto);
                Console.Clear();
            }

            Console.WriteLine("VALOR TOTAL COM DESCONTO: R$" + (valorTotalCompra - 150));

        }
    }
}
