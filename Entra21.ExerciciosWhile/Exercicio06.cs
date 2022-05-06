using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            //6. Solicite o nome, valor e a quantidade de produtos, enquanto o nome for diferente de sair,
            //Ao final deve - se aplicar ao valor total da compra um desconto de 5 %.

            double valorProduto = 0, valorTotalCompra = 0;
            int quantidadeProduto = 0;
            string nomeProduto = "";

            while (nomeProduto != "sair")
            {
                Console.Write("Informe o nome do produto: ");
                nomeProduto = Console.ReadLine().ToLower().Trim();

                if (nomeProduto != "sair")
                {
                    Console.Write("Informe o valor do produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Informe a quantidade: ");
                    quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                    valorTotalCompra = valorTotalCompra + (valorProduto * quantidadeProduto);
                }
            }

            Console.WriteLine("Valor total da compra: R$" + valorTotalCompra);

        }
    }
}
