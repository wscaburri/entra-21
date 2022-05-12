namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    {
        public void Executar()
        {
            //11. Solicite para o usuário dois números. Apresente o seguinte menu e de acordo com a escolha deve ser apresentado a operação aritmética,
            //isto deve ocorrer até que o mesmo escolha a opção de sair:


            Console.Write("informe o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            bool sair = false;

            while (sair == false)
            {
                Console.WriteLine(@"          MENU
1 - SOMAR
2 - SUBTRAIR
3 - MULTIPLICAR
4 - DIVIDIR
5 - SAIR");

                Console.Write("Informe a opção desejada ");
                int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                
                if (opcaoDesejada == 1)
                {
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));

                }
                else if (opcaoDesejada == 2)
                {
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                }
                else if (opcaoDesejada == 3)
                {
                    Console.WriteLine(numero1 + " * " + numero2 + " = " + (numero1 * numero2));
                }
                else if (opcaoDesejada == 4)
                {
                    Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                }
                else if (opcaoDesejada == 5)
                {
                    Console.Write("FIM DA OPERAÇÃO");
                    sair = true;
                }
                else
                {
                    Console.WriteLine("Opção Inválida, tente outra vez");
                }

                Console.WriteLine();
            }

        }
    }
}
