namespace Entra21.ExerciciosVetor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            //5. Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média dos pesos.

            double[] pesos = new double[5];

            for (int i = 0; i < pesos.Length; i++)
            {
                try
                {
                    Console.Write("Informe o peso: ");
                    pesos[i] = Convert.ToDouble(Console.ReadLine());

                    if (pesos[i] <= 0)
                    {
                        Console.WriteLine("Peso não pode ser menor ou igual a zero. Tente novamente");
                        i--;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Valor inválido. Tente novamente");
                    i--;
                }

            }

            double somaPesos = 0;

            for (int i = 0; i < pesos.Length; i++)
            {
                somaPesos = somaPesos + pesos[i];
            }

            double mediaPesos = somaPesos / 5;

            Console.Clear();

            Console.WriteLine("Soma total dos pesos: " + somaPesos.ToString("F") +
                "\nMédia dos pesos: " + mediaPesos.ToString("F"));
        }

    }
}

