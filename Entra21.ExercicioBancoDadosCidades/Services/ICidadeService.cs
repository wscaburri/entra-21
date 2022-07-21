using Entra21.ExercicioBancoDadosCidades.Models;

namespace Entra21.ExercicioBancoDadosCidades.Services
{
    internal interface ICidadeService
    {
        List<Cidade> ObterTodos();

        Cidade ObterPorId(int id);

        void Cadastrar(Cidade cidade);

        void Editar(Cidade cidade);

        void Apagar(int id);
    }
}