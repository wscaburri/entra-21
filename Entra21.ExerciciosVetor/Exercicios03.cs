using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicios03
    {
        public void Executar()
        {
            //3. Crie dois vetores para guardar o nome e preço de 7 produtos
            //E apresente o nome e preço dos sete produtos.

            string[] nomesProdutos = new string[7];
            double[] valorProdutos = new double[7];

            for (int i = 0; i < nomesProdutos.Length; i = i + 1)
            {
                Console.Write("Informe o nome do produto: ");
                nomesProdutos[i] = Console.ReadLine();

                Console.Write("Informe o preço do produto: R$ ");
                valorProdutos[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i < valorProdutos.Length; i = i + 1)
            {
                Console.WriteLine("Produto: " + nomesProdutos[i] +
                    "\nPreco: R$" + valorProdutos[i]);
                Console.WriteLine();
            }
        }
    }
}
