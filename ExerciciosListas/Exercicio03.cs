namespace Entra21.ExerciciosListas
{
    public class Exercicio03
    {
        public void Executar()
        {
            List<double> notas = new List<double>();

            Console.Write("Informe a primeira nota: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe a segunda nota: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe a terceira nota: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Nota 01 = " + notas[0] +
                "\nNota 02 = " + notas[1] +
                "\nNota 03 = " + notas[2]);
            Console.WriteLine();

            double mediaNotas = (notas[0] + notas[1] + notas[2]) / notas.Count;

            if (mediaNotas < 5)
                Console.Write("Média: " + mediaNotas.ToString("F") + " REPROVADO");
            else if (mediaNotas < 7)
                Console.Write("Média: " + mediaNotas.ToString("F") + " EM RECUPERAÇÃO");
            else
                Console.Write("Média: " + mediaNotas.ToString("F") + " APROVADO");
        }
    }
}