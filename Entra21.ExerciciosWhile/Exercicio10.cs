namespace Entra21.ExerciciosWhile
{
    internal class Exercicio10
    {
        public void Executar()
        {
            //10.Solicite um número e apresente:
            //● Os 50 números antecessores pares;
            //● Os 50 números sucessores ímpares.

            Console.Write("informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int indicePar = 100, indiceImpar = 100;

            Console.WriteLine("Antecessores Pares:");
            while (indicePar > 0)
            {
                numero = numero - 1;

                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }

                indicePar = indicePar - 1;
            }

            numero = numero + 100;

            Console.WriteLine("Sucessores Ímpares:");
            while (indiceImpar > 0)
            {
                numero = numero + 1;

                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }

                indiceImpar = indiceImpar - 1;
            }
        }
    }
}
