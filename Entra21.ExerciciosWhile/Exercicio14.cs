namespace Entra21.ExerciciosWhile
{
    internal class Exercicio14
    {
        public void Executar()
        {
            Console.Write("Informe a quantidade de caracteres desejados: ");
            int quantidadeCaracteres = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            string texto = "";

            Console.Clear();

            while (indice < quantidadeCaracteres)
            {
                Console.Write("Digite um caracter: ");
                char caracter = Convert.ToChar(Console.ReadLine());

                texto = texto + caracter;
                indice = indice + 1;
            }

            Console.Clear();
            Console.Write(texto);
            Console.WriteLine();
        }
    }
}
