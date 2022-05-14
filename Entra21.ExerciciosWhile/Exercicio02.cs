namespace Entra21.ExerciciosWhile
{
    internal class Exercicio02
    {
        public void Executar()
        {
            //2. Solicite nomes ao usuário até que o mesmo digite fim para o nome.

            string nome = "";
            int quantidadeNomes = 0;

            while (nome != "fim")
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine().ToLower().Trim();

                quantidadeNomes = quantidadeNomes + 1;
            }

            Console.WriteLine("Quantidade de nomes solicitados: " + (quantidadeNomes - 1));
        }
    }
}
