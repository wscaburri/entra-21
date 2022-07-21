using System.Data.SqlClient;

namespace Entra21.ExercicioBancoDadosCidades.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection();

            var connectionString = @"";

            conexao.ConnectionString = connectionString;

            conexao.Open();

            return conexao;
        }
    }
}