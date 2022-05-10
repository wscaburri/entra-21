using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            int indice = 0;
            double menorPeso, maiorAltura, maiorNome;
            string generoFeminino, generoMasculino;

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
            }            
        }
    }
}
