namespace Entra21.ExerciciosWhile
{
    internal class Exercicio18
    {
        public void Executar()
        {
            //1. Solicite o preço e nome da peça de 13 peças

            var valorValido = false;
            var totalValorPecas = 0;

            for (var i = 0; i < 13; i++)
            {
                Console.Write("Informe o nome da peça: ");
                var nomePeca = Console.ReadLine();

                valorValido = false;

                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Informe o valor da peça: ");
                        var valorPeca = Convert.ToDouble(Console.ReadLine());

                        if (valorPeca < 0)
                        {
                            valorValido = false;
                            Console.WriteLine("O valor não pode ser negativo. Tente novamente.");
                        }
                        else
                        {
                            valorValido = true;
                        }

                        totalValorPecas++;
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor incorreto. Tente novamente.");
                    }
                }
                
            }

            Console.WriteLine("Valor Total das peças: R$" + totalValorPecas);
        }
    }
}
