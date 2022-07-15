using Entra21.BancoDados01.Ado.Net.BancoDados;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class PersonagemService : IPersonagemService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM personagens WHERE id = @ID";

            // Substituir os @ no comando da query que será executada no banco de dados, prevenindo SQL Injection
            comando.Parameters.AddWithValue("@ID", id);

            // Executa o comando de delete
            comando.ExecuteNonQuery();

            // Fechar a conexao com o banco de dados
            comando.Connection.Close();
        }

        public void Cadastrar(Personagem personagem)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO personagens(id_tipo_personagem, id_editora, nome) VALUES (@ID_TIPO_PERSONAGEM, @ID_EDITORA, @NOME);";

            // Substituir os @ do INSERT com os valores preenchidos pelo usuário
            comando.Parameters.AddWithValue("@ID_TIPO_PERSONAGEM", personagem.TipoPersonagem.Id);
            comando.Parameters.AddWithValue("@ID_EDITORA", personagem.Editora.Id);
            comando.Parameters.AddWithValue("@NOME", personagem.Nome);

            // Executa o comando de insert
            comando.ExecuteNonQuery();

            // Fechar a conexão com o bando de dados
            comando.Connection.Close();
        }

        public void Editar(Personagem personagem)
        {
            throw new NotImplementedException();
        }

        public Personagem ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Personagem> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
