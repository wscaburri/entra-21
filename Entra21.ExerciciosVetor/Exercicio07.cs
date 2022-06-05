namespace Entra21.ExerciciosVetor
{
    internal class Exercicio07
    {
        public void Executar()
        {
            //Solicite a altura de 4 animais, apresente ao final a altura do animal com a menor altura.

            string[] nomesAnimais = new string[4];
            double[] alturaAnimais = new double[4];
            var menorAltura = 100.0;

            for (int i = 0; i < nomesAnimais.Length; i++)
            {
                Console.Write("Informe o nome do Animal: ");
                nomesAnimais[i] = Console.ReadLine();

                if (nomesAnimais[i].Length < 2)
                {
                    Console.WriteLine("Nome inválido. Tente novamente.");
                    i--;
                }
                else
                {
                    var alturaValida = false;

                    while (alturaValida == false)
                    {
                        try
                        {
                            Console.Write("Informe a altura do animal: ");
                            alturaAnimais[i] = Convert.ToDouble(Console.ReadLine());

                            if (alturaAnimais[i] <= 0)
                            {
                                Console.WriteLine("Altura não pode ser menor ou igual zero. Tente Novamente.");
                            }
                            else
                            {
                                if (alturaAnimais[i] < menorAltura)
                                {
                                    menorAltura = alturaAnimais[i];
                                }
                                alturaValida = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Valor inválido. Tente novamente.");
                        }
                    }
                }
            }

            Console.WriteLine("Menor Altura: " + menorAltura + "m.");
        }
    }
}
