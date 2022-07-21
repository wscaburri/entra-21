using Entra21.ExercicioBancoDadosCidades.Models;

namespace Entra21.ExercicioBancoDadosCidades.Services
{
    internal interface IUnidadeFederativaService
    {
        void Cadastrar(UnidadeFederativa unidadeFederativa);

        List<UnidadeFederativa> ObterTodos();

        void Apagar(int id);

        UnidadeFederativa ObterPorId(int id);

        void Editar(UnidadeFederativa unidadeFederativa);
    }
}