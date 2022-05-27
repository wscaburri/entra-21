using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class Livro
    {
        string tituloLivro;
        string autorLivro;
        string codigoIsbn;
        string idiomaOriginal;
        DateTime dataLancamento;
        int quantidadePaginas;
        int quantidadePaginasLidas;
        int quantidadeReleituras;

        public void ApresentarTituloAutor()
        {
            Console.WriteLine("Título: " + tituloLivro);
        }

        public void ApresentarQuantidadePaginasParaLer()
        {
            var quantidadePaginasParaLer = quantidadePaginas - quantidadePaginasLidas;
            Console.WriteLine(quantidadePaginasParaLer);
        }

        public void ApresentarQuantidadePaginasLidasNoTotal()
        {
            Console.WriteLine("Total de páginas lidas: " + quantidadePaginasLidas);
        }

    }
}
