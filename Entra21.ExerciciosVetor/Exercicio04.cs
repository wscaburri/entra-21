using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            //4. Crie um vetor para armazenar as notas de uma disciplina. A disciplina deve conter 4 notas.
            //Solicite para o usuário o nome e as quatro notas, armazenando as notas em um vetor, realize a média destas notas e apresente.

            Console.Write("Informe o nome do Aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine();

            Console.Write("informe o nome da disciplina: ");
            string nomeDisciplina = Console.ReadLine();

            Console.Clear();

            double[] notasDisciplina = new double[4];

            for (int i = 0; i < notasDisciplina.Length; i++)
            {
                try
                {
                    Console.Write("Informe a nota: ");
                    notasDisciplina[i] = Convert.ToDouble(Console.ReadLine());

                    if (notasDisciplina[i] < 0 || notasDisciplina[i] > 10)
                    {
                        Console.WriteLine("Valor inválido. Tente novamente");
                        i--;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    i--;
                }

            }

            double somaNotas = 0;

            for (int i = 0; i < notasDisciplina.Length; i++)
            {
                somaNotas = somaNotas + notasDisciplina[i];
            }

            double mediaNotas = somaNotas / 4;

            Console.Clear();

            Console.WriteLine("Nome do Aluno: " + nomeAluno +
                "\nDisciplina: " + nomeDisciplina +
                "\n" +
                "\nMédia: " + mediaNotas.ToString("F"));
        }
    }
}
