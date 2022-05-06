using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio03
    {
        public void Executar()
        {
            //3. Solicite a idade para o usuário até que ele digite uma idade maior que 128.

            int idade = 0;

            while (idade <= 128)
            {
                Console.Write("Digite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
