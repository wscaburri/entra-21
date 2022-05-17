using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio19
    {
        public void Executar()
        {
            //5. Faça um programa que solicite a quantidade de carros que o usuário deseja cadastrar,
            //após isto solicite para o usuário o modelo, valor e ano do carro, 
            //até que atinja a quantidade de carros para cadastro.
            //Apresente ao final:
            //● Média do ano dos carros;
            //● Média do valor dos carros;
            //● Quantidade de carros que começam com a letra G;
            //● Quantidade de carros que começam com a letra A.

            Console.Write("Informe a quantidade de carros para o cadastro: ");
            var quantidadeCarrosCadastrados = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            var totalAnoCarros = 0; var totalValorCarros = 0.0;
            var carrosLetraA = 0; var carrosLetraG = 0;
            var valorValido = false; var anoValido = false;

            for (var i = 0; i < quantidadeCarrosCadastrados; i++)
            {
                Console.Write("Informe o modelo do carro: ");
                var modeloCarro = Console.ReadLine().Trim().ToLower();

                if (modeloCarro.StartsWith("a"))
                {
                    carrosLetraA++;
                }

                if (modeloCarro.StartsWith("g"))
                {
                    carrosLetraG++;
                }

                valorValido = false;
                anoValido = false;

                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Informe o valor do carro: R$");
                        var valorCarro = Convert.ToDouble(Console.ReadLine());

                        if (valorCarro <= 0)
                        {
                            valorValido = false;
                            Console.WriteLine("Valor não pode ser negativo. Tente novamente.");
                        }
                        else
                        {
                            valorValido = true;
                        }

                        totalValorCarros += valorCarro;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor incorreto. Tente novamente.");
                    }
                }

                while (anoValido == false)
                {
                    try
                    {
                        Console.Write("Informe o ano do carro: ");
                        var anoCarro = Convert.ToInt32(Console.ReadLine());

                        if (anoCarro < 1886)
                        {
                            anoValido = false;
                            Console.WriteLine("Ano inválido. Tente novamente.");
                        }
                        else
                        {
                            anoValido = true;
                        }

                        totalAnoCarros += anoCarro;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ano incorreto. Tente novamente.");
                    }
                }

                Console.Clear();
            }

            var mediaValorCarro = totalValorCarros / quantidadeCarrosCadastrados;
            var mediaAnoCarro = totalAnoCarros / quantidadeCarrosCadastrados;

            Console.WriteLine("Quantidade de carros cadastrados: " + quantidadeCarrosCadastrados +
                "\nQuantidade de carros que começam com a letra A: " + carrosLetraA +
                "\nQuantidade de carros que começam com a letra G: " + carrosLetraG +
                "\n" +
                "\nA média do ano dos carros é de: " + mediaAnoCarro +
                "\nA média do valor dos carros é de: R$" + mediaValorCarro.ToString("F"));
        }
    }
}
