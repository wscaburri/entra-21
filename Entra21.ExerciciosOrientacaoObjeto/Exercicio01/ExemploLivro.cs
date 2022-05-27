using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            Livro livro = new Livro();

            Console.Write("Nome do livro: ");
            livro.TituloLivro = Console.ReadLine();
            Console.Write("Autor do livro: ");
            livro.AutorLivro = Console.ReadLine();
            Console.Write("Código ISBN: ");
            livro.CodigoIsbn = Console.ReadLine();
            Console.Write("Idioma Original: ");
            livro.IdiomaOriginal = Console.ReadLine();
            Console.Write("Data de Lançamento: ");
            livro.DataLancamento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Total de Páginas: ");
            livro.QuantidadePaginas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade de páginas lidas: ");
            livro.QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade de releituras: ");
            livro.QuantidadeReleituras = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            livro.ApresentarTituloAutor();
            livro.ApresentarQuantidadePaginasParaLer();
            livro.ApresentarQuantidadePaginasLidasNoTotal();
        }
    }
}
