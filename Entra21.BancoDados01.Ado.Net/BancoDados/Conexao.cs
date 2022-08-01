using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.BancoDados
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            // Instanciado um objeto da classe SqlConnection, que permitirá fazer selects, inserts, updates, deletes, etc.
            SqlConnection conexao = new SqlConnection();

            // string que contém o caminho para o banco de dados, o que permitirá conectar ao banco de dados.
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wscab\source\repos\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

            // Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexão com o bando de dados
            conexao.Open();

            return conexao;
        }
    }
}