namespace Entra21.ExerciciosWhile
{
    internal class Exercicio21
    {
        public void Executar()
        {
            //10.Solicite um número e apresente:
            //● Os 50 números antecessores pares;
            //● Os 50 números sucessores ímpares.

            var opcaoValida = false;

            while (opcaoValida == false)
            {
                try
                {
                    Console.Write("Informe um número inteiro: ");
                    var numero = Convert.ToInt32(Console.ReadLine());

                    opcaoValida = true;

                    Console.WriteLine("Números Antecessores Pares:");

                    for (int i = 0; i < 100; i++)
                    {
                        numero--;

                        if (numero % 2 == 0)
                        {                            
                            Console.WriteLine(numero);
                        }
                    }

                    numero += 100;

                    Console.WriteLine();

                    Console.WriteLine("Números Sucessores Ímpares:");

                    for (int j = 100; j > 0; j--)
                    {
                        numero++;

                        if (numero % 2 != 0)
                        {                            
                            Console.WriteLine(numero);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opção Inválida. Digite um número inteiro válido");
                }
            }
        }
    }
}
