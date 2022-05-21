using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicios04
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

            for (int i = 0; i < notasDisciplina.Length; i = i + 1)
            {
                Console.Write("Informe a nota: ");
                notasDisciplina[i] = Convert.ToDouble(Console.ReadLine());
            }

            double somaNotas = 0;

            for (int i = 0; somaNotas < notasDisciplina.Length; i = i + 1)
            {
                somaNotas = somaNotas + notasDisciplina[i];
            }

            double mediaNotas = somaNotas / 4;

            Console.WriteLine(mediaNotas);
        }
    }
}
