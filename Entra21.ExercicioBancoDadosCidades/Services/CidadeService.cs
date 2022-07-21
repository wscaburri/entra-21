using Entra21.ExercicioBancoDadosCidades.DataBase;
using Entra21.ExercicioBancoDadosCidades.Models;
using System.Data;

namespace Entra21.ExercicioBancoDadosCidades.Services
{
    internal class CidadeService : ICidadeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM cidades WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO cidades(id_unidade_federativa, nome, quantidade_habitantes, data_hora_fundacao, pib) " +
                "VALUES (@ID_UNIDADE_FEDERATIVA, @NOME, @QUANTIDADE_HABITANTES, @DATA_HORA_FUNDACAO, @PIB);";

            comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuandidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE cidades SET " +
                "id_unidade_federativa = @ID_UNIDADE_FEDERATIVA, nome = @NOME, quantidade_habitantes = @QUANTIDADE_HABITANTES, " +
                "data_hora_fundacao = @DATA_HORA_FUNDACAO, pib = @PIBWHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuandidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);
            comando.Parameters.AddWithValue("@ID", cidade.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Cidade ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, id_unidade_federativa, nome, quantidade_habitantes, data_hora_fundacao, pib FROM cidades WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();

            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];

            var cidade = new Cidade();

            cidade.Id = Convert.ToInt32(registro["id"]);
            cidade.Nome = registro["nome"].ToString();
            cidade.QuandidadeHabitantes = Convert.ToInt32(registro["quantidade_habitantes"]);
            cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
            cidade.Pib = Convert.ToDouble(registro["pib"]);
            cidade.UnidadeFederativa = new UnidadeFederativa();
            cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["id_unidade_federativa"]);

            conexao.Close();

            return cidade;
        }

        public List<Cidade> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
c.id AS 'id',
c.nome AS 'nome',
c.quantidade_habitantes AS 'quantidade_habitantes',
c.data_hora_fundacao AS 'data_hora_fundacao',
c.pib AS 'pib',
uf.id AS 'unidade_federativa_id',
uf.nome AS 'unidade_federativa_nome',
uf.sigla AS 'unidade_federativa_sigla'
FROM cidades AS c
INNER JOIN unidades_federativas AS uf ON(c.id_unidade_federativa = uf.id)";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var cidades = new List<Cidade>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var cidade = new Cidade();

                cidade.Id = Convert.ToInt32(registro["id"]);
                cidade.Nome = registro["nome"].ToString();
                cidade.QuandidadeHabitantes = Convert.ToInt32(registro["quantidade_habitantes"]);
                cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
                cidade.Pib = Convert.ToDouble(registro["pib"]);
                cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["unidade_federativa_id"]);
                cidade.UnidadeFederativa.Nome = registro["unidade_federativa_nome"].ToString();
                cidade.UnidadeFederativa.Sigla = registro["unidade_federativa_sigla"].ToString();

                cidades.Add(cidade);
            }

            return cidades;
        }
    }
}