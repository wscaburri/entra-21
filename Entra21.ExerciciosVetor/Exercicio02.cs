﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            //2. Crie um vetor para guardar 10 nomes e apresente os dez nomes.

            string[] nomes = new string[10];

            for (int i = 0; i < nomes.Length; i = i + 1)
            {
                Console.Write("Informe um nome: ");
                nomes[i] = Console.ReadLine();

                if (nomes[i].Length < 2)
                {
                    Console.WriteLine("Nome inválido, tente novamente");
                    i--;
                }
            }

            Console.Clear();

            for (int i = 0; i < nomes.Length; i = i + 1)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
