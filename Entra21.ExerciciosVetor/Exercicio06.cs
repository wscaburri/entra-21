namespace Entra21.ExerciciosVetor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            //6. Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior idade.

            int[] idades = new int[9];

            for (int i = 0; i < idades.Length; i++)
            {
                try
                {
                    Console.Write("Informe a idade: ");
                    idades[i] = Convert.ToInt32(Console.ReadLine());

                    if (idades[i] < 0 || idades[i] > 125)
                    {
                        Console.WriteLine("Idade incorreta. Tente novamente");
                        i--;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Valor Inválido. Tente novamente");
                    i--;
                }
            }

            int maiorIdade = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                }
            }

            Console.WriteLine("Maior Idade: " + maiorIdade);
        }
    }
}
