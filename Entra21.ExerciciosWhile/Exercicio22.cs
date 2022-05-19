using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio22
    {
        public void Executar()
        {
            Console.WriteLine(@"***********************************CARDÁPIO************************************");
            Console.WriteLine("|CÓDIGO |    TIPO    |                    NOME                     |  VALOR   |");
            Console.WriteLine("| 1     | Bolos      | Bolo Brigadeiro                             | R$ 29,50 |");
            Console.WriteLine("| 2     | Bolos      | Bolo Floresta Negra                         | R$ 2,00  |");
            Console.WriteLine("| 3     | Bolos      | Bolo Leite com Nutella                      | R$ 29,23 |");
            Console.WriteLine("| 4     | Bolos      | Bolo Mousse de Chocolate                    | R$ 7,10  |");
            Console.WriteLine("| 5     | Bolos      | Bolo Nega Maluca                            | R$ 19,33 |");
            Console.WriteLine("| 6     | Doces      | Bomba de Creme                              | R$ 17,71 |");
            Console.WriteLine("| 7     | Doces      | Bomba de Morango                            | R$ 4,82  |");
            Console.WriteLine("| 8     | Sanduíches | Filé-Mignon com fritas e cheddar            | R$ 21,16 |");
            Console.WriteLine("| 9     | Sanduíches | Hambúrguer com queijos, champignon e rúcula | R$ 12,70 |");
            Console.WriteLine("| 10    | Sanduíches | Provolone com salame                        | R$ 19,70 |");
            Console.WriteLine("| 11    | Sanduíches | Vegetariano de berinjela                    | R$ 28,22 |");
            Console.WriteLine("| 12    | Pizzas     | Calabresa                                   | R$ 8,98  |");
            Console.WriteLine("| 13    | Pizzas     | Napolitana                                  | R$ 0,42  |");
            Console.WriteLine("| 14    | Pizzas     | Peruana                                     | R$ 18,36 |");
            Console.WriteLine("| 15    | Pizzas     | Portuguesa                                  | R$ 27,50 |");
            Console.WriteLine("| 16                 | SAIR                                                   |");

            var quantidadeTotalProdutos = 0;
            var quantidadeBolos = 0; var quantidadeDoces = 0; var quantidadeSanduiches = 0; var quantidadePizzas = 0;
            var valorTotalPedido = 0.0;
            var sairCardapio = false; var opcaoValida = false; var quantidadeValida = false;

            while (sairCardapio == false)
            {
                opcaoValida = false;

                while (opcaoValida == false)
                {
                    try
                    {
                        Console.Write("Escolha a opção desejada: ");
                        var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                        if (opcaoDesejada > 0 && opcaoDesejada < 16)
                        {
                            quantidadeValida = false;

                            while (quantidadeValida == false)
                            {
                                try
                                {
                                    Console.Write("Informe a quantidade: ");
                                    var quantidadeItem = Convert.ToInt32(Console.ReadLine());

                                    if (opcaoDesejada == 1)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeBolos += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 29.50);
                                    }
                                    else if (opcaoDesejada == 2)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeBolos += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 2);
                                    }
                                    else if (opcaoDesejada == 3)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeBolos += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 29.23);
                                    }
                                    else if (opcaoDesejada == 4)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeBolos += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 7.10);
                                    }
                                    else if (opcaoDesejada == 5)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeBolos += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 19.33);
                                    }
                                    else if (opcaoDesejada == 6)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeDoces += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 17.71);
                                    }
                                    else if (opcaoDesejada == 7)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeDoces += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 4.82);
                                    }
                                    else if (opcaoDesejada == 8)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeSanduiches += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 21.16);
                                    }
                                    else if (opcaoDesejada == 9)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeSanduiches += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 12.70);
                                    }
                                    else if (opcaoDesejada == 10)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeSanduiches += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 19.70);
                                    }
                                    else if (opcaoDesejada == 11)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadeSanduiches += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 28.22);
                                    }
                                    else if (opcaoDesejada == 12)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadePizzas += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 8.98);
                                    }
                                    else if (opcaoDesejada == 13)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadePizzas += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 0.42);
                                    }
                                    else if (opcaoDesejada == 14)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadePizzas += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 18.36);
                                    }
                                    else if (opcaoDesejada == 15)
                                    {
                                        quantidadeTotalProdutos += quantidadeItem;
                                        quantidadePizzas += quantidadeItem;
                                        valorTotalPedido += (quantidadeItem * 27.50);
                                    }

                                    quantidadeValida = true;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Opção Inválida. Digite um número válido.");
                                }
                            }
                        }
                        else if (opcaoDesejada == 16)
                        {
                            Console.WriteLine("Pedido Finalizado");
                            sairCardapio = true;
                        }
                        else
                        {
                            Console.WriteLine("Opção Inválida, tente novamente.");
                        }

                        opcaoValida = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Opção Inválida. Digite um número válido.");
                    }

                }

            }

            Console.Clear();

            Console.WriteLine("Quantidade de Bolos pedidos: " + quantidadeBolos);
            Console.WriteLine("Quantidade de Doces pedidos: " + quantidadeDoces);
            Console.WriteLine("Quantidade de Sanduíches pedidos: " + quantidadeSanduiches);
            Console.WriteLine("Quantidade de Pizzas pedidas: " + quantidadePizzas);
            Console.WriteLine();
            Console.WriteLine("TOTAL DO PEDIDO: R$" + valorTotalPedido.ToString("F"));
            Console.WriteLine("Média do valor dos Produtos: R$" + (valorTotalPedido / quantidadeTotalProdutos).ToString("F"));

        }
    }
}
