using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class Livro
    {
        public string TituloLivro;
        public string AutorLivro;
        public string CodigoIsbn;
        public string IdiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleituras;

        public void ApresentarTituloAutor()
        {
            Console.WriteLine("Título: " + TituloLivro +
                "\nAutor: " + AutorLivro);
        }

        public void ApresentarQuantidadePaginasParaLer()
        {
            var quantidadePaginasParaLer = QuantidadePaginas - QuantidadePaginasLidas;
            Console.WriteLine("Quantidade de Páginas para ler: " + quantidadePaginasParaLer);
        }

        public void ApresentarQuantidadePaginasLidasNoTotal()
        {
            Console.WriteLine("Total de páginas lidas: " + (QuantidadePaginas * QuantidadeReleituras + QuantidadePaginasLidas));
        }
    }
}
