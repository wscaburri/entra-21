internal class Exercicio12
{
    public Exercicio12()
    {
    }

    internal void Executar()
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
        Console.WriteLine("| 11    | Sanduíches | Vegetariano de berinjela                    | R$ 12,70 |");
        Console.WriteLine("| 12    | Pizzas     | Calabresa                                   | R$ 8,98  |");
        Console.WriteLine("| 13    | Pizzas     | Napolitana                                  | R$ 0,42  |");
        Console.WriteLine("| 14    | Pizzas     | Peruana                                     | R$ 18,36 |");
        Console.WriteLine("| 15    | Pizzas     | Portuguesa                                  | R$ 27,50 |");
        Console.WriteLine("| 16                 | SAIR                                                   |");

        int indice = 0, quantidadeProdutos = 0, quantidadeBolos = 0, quantidadeDoces = 0, quantidadeSanduiches = 0, quantidadePizzas = 0;
        double valorTotalPedido = 0;

        while (indice < 1)
        {
            Console.Write("Escolha as opções desejadas: ");
            int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

            if (opcaoDesejada == 1)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeBolos = quantidadeBolos + 1;
                valorTotalPedido = valorTotalPedido + 29.50;
            }
            else if (opcaoDesejada == 2)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeBolos = quantidadeBolos + 1;
                valorTotalPedido = valorTotalPedido + 2;
            }
            else if (opcaoDesejada == 3)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeBolos = quantidadeBolos + 1;
                valorTotalPedido = valorTotalPedido + 29.23;
            }
            else if (opcaoDesejada == 4)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeBolos = quantidadeBolos + 1;
                valorTotalPedido = valorTotalPedido + 7.10;
            }
            else if (opcaoDesejada == 5)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeBolos = quantidadeBolos + 1;
                valorTotalPedido = valorTotalPedido + 19.33;
            }
            else if (opcaoDesejada == 6)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeDoces = quantidadeDoces + 1;
                valorTotalPedido = valorTotalPedido + 17.71;
            }
            else if (opcaoDesejada == 7)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeDoces = quantidadeDoces + 1;
                valorTotalPedido = valorTotalPedido + 4.82;
            }
            else if (opcaoDesejada == 8)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeSanduiches = quantidadeSanduiches + 1;
                valorTotalPedido = valorTotalPedido + 21.16;
            }
            else if (opcaoDesejada == 9)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeSanduiches = quantidadeSanduiches + 1;
                valorTotalPedido = valorTotalPedido + 12.70;
            }
            else if (opcaoDesejada == 10)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeSanduiches = quantidadeSanduiches + 1;
                valorTotalPedido = valorTotalPedido + 19.70;
            }
            else if (opcaoDesejada == 11)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadeSanduiches = quantidadeSanduiches + 1;
                valorTotalPedido = valorTotalPedido + 12.70;
            }
            else if (opcaoDesejada == 12)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadePizzas = quantidadePizzas + 1;
                valorTotalPedido = valorTotalPedido + 8.98;
            }
            else if (opcaoDesejada == 13)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadePizzas = quantidadePizzas + 1;
                valorTotalPedido = valorTotalPedido + 0.42;
            }
            else if (opcaoDesejada == 14)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadePizzas = quantidadePizzas + 1;
                valorTotalPedido = valorTotalPedido + 18.36;
            }
            else if (opcaoDesejada == 15)
            {
                quantidadeProdutos = quantidadeProdutos + 1;
                quantidadePizzas = quantidadePizzas + 1;
                valorTotalPedido = valorTotalPedido + 27.50;
            }
            else if (opcaoDesejada == 16 )
            {
                Console.WriteLine("Pedido Finalizado");
                indice = 1;
            }
            else
            {
                Console.WriteLine("Opção Inválida, tente novamente");
            }
        }

        Console.WriteLine("Valor Total do Pedido: R$" + valorTotalPedido);
        Console.WriteLine("Quantidade de bolos pedido: " + quantidadeBolos);
        Console.WriteLine("Quantidade de doces pedido: " + quantidadeDoces);
        Console.WriteLine("Quantidade de sanduíches pedido: " + quantidadeSanduiches);
        Console.WriteLine("Quantidade de pizzas pedida: " + quantidadePizzas);
        Console.WriteLine("Média dos produtos: R$ " + (valorTotalPedido / quantidadeProdutos).ToString("F"));
    }
}