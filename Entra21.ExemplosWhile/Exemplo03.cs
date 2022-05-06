using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo03
    {
        public void Executar()
        {
            string nome = "";
            int quantidade = 0;

            while (nome != "fim")
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine().ToLower().Trim();
                quantidade = quantidade + 1;
            }

            Console.WriteLine("A quantidade de nome foi de: " + quantidade);

        }
    }
}
