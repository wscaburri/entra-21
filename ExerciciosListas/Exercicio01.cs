namespace Entra21.ExerciciosListas
{
    public class Exercicio01
    {
        public void Executar()
        {
            List<string> melhoresFilmes = new List<string>();

            melhoresFilmes.Add("Dragon Ball Evolution");
            melhoresFilmes.Add("Titanic");
            melhoresFilmes.Add("Lanterna Verde");

            Console.WriteLine("Melhores Filmes: ");
            Console.WriteLine("1 = " + melhoresFilmes[0] +
                "\n2 = " + melhoresFilmes[1] +
                "\n3 = " + melhoresFilmes[2]);

            Console.WriteLine();

            melhoresFilmes.Add("");

            melhoresFilmes[0] = "Dragon Ball Super: Broly";

            melhoresFilmes.Remove("Lanterna Verde");

            bool contemFilmeLanternaVerde = melhoresFilmes.Contains("Lanterna Verde");

            if (contemFilmeLanternaVerde == true)
                Console.WriteLine("Contém o filme Lanterna Verde");
            else
                Console.WriteLine("Não contém o filme Lanterna Verde");

            Console.WriteLine();

            melhoresFilmes.Add("Quarteto Fantástico");

            Console.WriteLine("Melhores Filmes: ");
            Console.WriteLine("1 = " + melhoresFilmes[0] +
                "\n2 = " + melhoresFilmes[1] +
                "\n3 = " + melhoresFilmes[2] +
                "\n4 = " + melhoresFilmes[3]);

            Console.WriteLine();

            melhoresFilmes[1] = "Titanic 2";

            Console.WriteLine("Melhores Filmes: ");
            Console.WriteLine("1 = " + melhoresFilmes[0] +
                "\n2 = " + melhoresFilmes[1] +
                "\n3 = " + melhoresFilmes[2] +
                "\n4 = " + melhoresFilmes[3]);

            Console.WriteLine();

            bool contemFilmeLagoaAzul = melhoresFilmes.Contains("A Lagoa Azul");

            if (contemFilmeLagoaAzul == true)
                Console.WriteLine("Contém o filme A Lagoa Azul");
            else
                Console.WriteLine("Não contém o filme A Lagoa Azul");
        }
    }
}