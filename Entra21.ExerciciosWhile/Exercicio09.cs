namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            //9. Solicite um número e faça o fatorial deste número, utilizando while.

            Console.Write("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int fatorial = numero;

            while (numero > 0)
            {
                Console.WriteLine(numero);
                numero = numero - 1;

                if (numero > 0)
                {
                    fatorial = fatorial * numero;
                }
            }

            Console.WriteLine("Resultado = " + fatorial);
        }
    }
}
