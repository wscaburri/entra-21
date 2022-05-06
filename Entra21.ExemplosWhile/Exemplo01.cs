using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    // Classe => PascalCase
    internal class Exemplo01
    {
        // Método => PascalCase
        public void Executar()
        {
            int indiceAuxiliar = 0;

            while (indiceAuxiliar < 3)
            {
                Console.WriteLine("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                indiceAuxiliar = indiceAuxiliar + 1;
            }
        }
    }
}
