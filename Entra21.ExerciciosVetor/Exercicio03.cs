using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            //3. Crie dois vetores para guardar o nome e preço de 7 produtos
            //E apresente o nome e preço dos sete produtos.

            string[] nomesProdutos = new string[2];
            double[] valorProdutos = new double[2];
            bool valorValido = false;

            for (int i = 0; i < nomesProdutos.Length; i = i + 1)
            {
                Console.Write("Informe o nome do produto: ");
                nomesProdutos[i] = Console.ReadLine();

                if (nomesProdutos[i].Length < 3)
                {
                    Console.WriteLine("Nome inválido. Tente novamente.");
                    i--;
                }
                else
                {
                    valorValido = false;

                    while (valorValido == false)
                    {
                        try
                        {
                            Console.Write("Informe o preço do produto: R$ ");
                            valorProdutos[i] = Convert.ToDouble(Console.ReadLine());

                            if (valorProdutos[i] < 0)
                            {
                                Console.WriteLine("Valor não pode ser menor que zero. Tente novamente");
                                valorValido = false;
                            }
                            else
                            {
                                valorValido = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Valor Incorreto. Tente novamente");
                            valorValido = false;
                        }
                    }

                }
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
