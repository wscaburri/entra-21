using Entra21.BancoDados01.Ado.Net.Models;
using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    // Dois pontos seguido de uma interface, quer dizer que a classe será obrigada a implementar os métodos(contratos) estabelecidos na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            //Será descrito a implementação do contrato definido na interface            

            // Instanciado um objeto da classe SqlConnection, que permitirá fazer selects, inserts, updates, deletes, etc.
            SqlConnection conexao = new SqlConnection();

            // string que contém o caminho para o banco de dados, o que permitirá conectar ao banco de dados.
            var connectionString = @"";

            // Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexão com o bando de dados
            conexao.Open();
        } 
    }
}
