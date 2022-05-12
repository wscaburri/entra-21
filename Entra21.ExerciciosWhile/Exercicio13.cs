namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            int indice = 0;
            int generoFeminino = 0, generoMasculino = 0,
                menorQuantidadeCartoesAmarelos = 1000, maiorQuantidadeCartoesAmarelos = 0,
                menorQuantidadeCartoesVermelhos = 1000, maiorQuantidadeCartoesVermelhos = 0;
            double maiorPeso = 0, menorPeso = 1000, maiorAltura = 0;
            string jogadorMaiorPeso = "", jogadorMenorPeso = "", jogadorMaiorAltura = "",
                maiorNome = "", menorNome = "", jogadorMenorQuantidadeAmarelo = "", jogadorMaiorQuantidadeAmarelo = "",
                jogadorMenorQuantidadeVermelho = "", jogadorMaiorQuantidadeVermelho = "";

            while (indice < 3)
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("informe o Peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("informe o Sexo: ");
                string sexo = Console.ReadLine();
                Console.Write("Quantidade de Gols Marcados: ");
                int quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de Cartões Amarelos Recebidos: ");
                int quantidadeCartoesAmarelosRecebidos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de Cartões Vermelhos Recebidos: ");
                int quantidadeCartoesVermelhosRecebidos = Convert.ToInt32(Console.ReadLine());

                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    jogadorMenorPeso = nome;
                }

                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    jogadorMaiorPeso = nome;
                }

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    jogadorMaiorAltura = nome;
                }

                if (sexo.ToUpper().Trim().StartsWith("F"))
                {
                    generoFeminino = generoFeminino + 1;
                }

                if (sexo.ToUpper().Trim().StartsWith("M"))
                {
                    generoMasculino = generoMasculino + 1;
                }

                if (quantidadeCartoesAmarelosRecebidos < menorQuantidadeCartoesAmarelos)
                {
                    menorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelosRecebidos;
                    jogadorMenorQuantidadeAmarelo = nome;
                }

                if (quantidadeCartoesAmarelosRecebidos > maiorQuantidadeCartoesAmarelos)
                {
                    maiorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelosRecebidos;
                    jogadorMaiorQuantidadeAmarelo = nome;
                }

                if (quantidadeCartoesVermelhosRecebidos < menorQuantidadeCartoesVermelhos)
                {
                    menorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhosRecebidos;
                    jogadorMenorQuantidadeVermelho = nome;
                }

                if (quantidadeCartoesVermelhosRecebidos > maiorQuantidadeCartoesVermelhos)
                {
                    maiorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhosRecebidos;
                    jogadorMaiorQuantidadeVermelho = nome;
                }

                indice = indice + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Menor Peso = " + jogadorMenorPeso +
                "\nMaior Peso = " + jogadorMaiorPeso +
                "\nMaior Altura = " + jogadorMaiorAltura +
                "\nQuantidade Sexo Feminino = " + generoFeminino +
                "\nQuantidade Sexo Masculino = " + generoMasculino +
                "\nMenor Quantidade de Cartões Amarelos = " + jogadorMenorQuantidadeAmarelo +
                "\nMaior Quantidade de Cartões Amarelos = " + jogadorMaiorQuantidadeAmarelo +
                "\nMenor Quantidade de Cartões Vermelhos = " + jogadorMenorQuantidadeVermelho +
                "\nMaior Quantidade de Cartões Vermelhos = " + jogadorMaiorQuantidadeVermelho);
        }
    }
}
