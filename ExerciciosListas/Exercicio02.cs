namespace Entra21.ExerciciosListas
{
    public class Exercicio02
    {
        public void Executar()
        {
            List<string> conteudosPassados = new List<string>();

            conteudosPassados.Add("Como fazer um bolo");

            Console.WriteLine("Conteúdos Passados:");
            Console.WriteLine("1 = " + conteudosPassados[0]);

            Console.WriteLine();

            int indiceConteudo = conteudosPassados.IndexOf("Como fazer um bolo");
            conteudosPassados[indiceConteudo] = "Algoritimos onde vivem? Do que se alimentam";

            conteudosPassados.Add("Variáveis");
            conteudosPassados.Add("Mais para frente");

            indiceConteudo = conteudosPassados.IndexOf("Mais para frente");
            conteudosPassados[indiceConteudo] = "If com E";

            conteudosPassados.Add("If com OU");
            conteudosPassados.Add("While");
            conteudosPassados.Add("For");

            Console.WriteLine("Conteúdos Passados:");
            Console.WriteLine("1 = " + conteudosPassados[0] +
                "\n2 = " + conteudosPassados[1] +
                "\n3 = " + conteudosPassados[2] +
                "\n4 = " + conteudosPassados[3] +
                "\n5 = " + conteudosPassados[4] +
                "\n6 = " + conteudosPassados[5]);

            Console.WriteLine();

            conteudosPassados.Add("Vetor");
            conteudosPassados.Add("Vetor");

            conteudosPassados.RemoveAt(6);
            conteudosPassados.Remove("Vetor");

            conteudosPassados.Add("Vetor");

            indiceConteudo = conteudosPassados.IndexOf("Vetor");
            conteudosPassados[indiceConteudo] = "Vetor com for, um amor na minha vida";

            Console.WriteLine("Conteúdos Passados:");
            Console.WriteLine("1 = " + conteudosPassados[0] +
                "\n2 = " + conteudosPassados[1] +
                "\n3 = " + conteudosPassados[2] +
                "\n4 = " + conteudosPassados[3] +
                "\n5 = " + conteudosPassados[4] +
                "\n6 = " + conteudosPassados[5] +
                "\n7 = " + conteudosPassados[6]);

            Console.WriteLine();

            conteudosPassados.Add("Classes, propriedades e métodos");

            Console.WriteLine("Conteúdos Passados:");
            Console.WriteLine("1 = " + conteudosPassados[0] +
                "\n2 = " + conteudosPassados[1] +
                "\n3 = " + conteudosPassados[2] +
                "\n4 = " + conteudosPassados[3] +
                "\n5 = " + conteudosPassados[4] +
                "\n6 = " + conteudosPassados[5] +
                "\n7 = " + conteudosPassados[6] +
                "\n8 = " + conteudosPassados[7]);
        }
    }
}