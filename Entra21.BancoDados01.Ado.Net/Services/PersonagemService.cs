using Entra21.BancoDados01.Ado.Net.BancoDados;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            // conectado no banco de dados e definido a query que será executada
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE personagens SET id_tipo_personagem = @ID_TIPO_PERSONAGEM, id_editora = @ID_EDITORA, nome = @NOME WHERE id = @ID";

            // Substituir os @ do update com os valores preenchidos pelo usuário
            comando.Parameters.AddWithValue("@ID_TIPO_PERSONAGEM", personagem.TipoPersonagem.Id);
            comando.Parameters.AddWithValue("@ID_EDITORA", personagem.Editora.Id);
            comando.Parameters.AddWithValue("@NOME", personagem.Nome);
            comando.Parameters.AddWithValue("@ID", personagem.Id);

            // Executa o UPDATE na tabela personagens
            comando.ExecuteNonQuery();

            // Fechar conexão
            comando.Connection.Close();
        }

        public Personagem ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, id_tipo_personagem, id_editora, nome FROM personagens WHERE id = @ID";

            // Substituir o @ do comando do select com o id
            comando.Parameters.AddWithValue("@ID", id);

            // Cria tabela em memória para armazenar o registro da consulta 
            var dataTable = new DataTable();

            // Carregar os registros no dataTable
            dataTable.Load(comando.ExecuteReader());

            // Verifica se encontrou um registro
            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var personagem = new Personagem();
            personagem.Id = Convert.ToInt32(registro["id"]);

            // Instanciar a editora para poder armazenar o id da editora
            personagem.Editora = new Editora();
            personagem.Editora.Id = Convert.ToInt32(registro["id_editora"]);

            personagem.TipoPersonagem = new TipoPersonagem();
            personagem.TipoPersonagem.Id = Convert.ToInt32(registro["id_tipo_personagem"]);

            personagem.Nome = registro["nome"].ToString();

            conexao.Close();

            return personagem;
        }

        public List<Personagem> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
p.id AS 'id',
p.nome AS 'nome',
tp.id AS 'tipo_personagem_id',
tp.tipo AS 'tipo_personagem_tipo',
e.id AS 'editora_id',
e.nome AS 'editora_nome'
FROM personagens AS p
INNER JOIN tipos_personagens AS tp ON(p.id_tipo_personagem = tp.id)
INNER JOIN editoras AS e ON(p.id_editora = e.id)";

            // Criado tabela em memória para armazenar os registros do SELECT
            var tabelaEmMemoria = new DataTable();

            // Executa o SELECT armazenando na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criado lista de personagens para armazenar os registros
            var personagens = new List<Personagem>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                // Instanciado o personagem populando com os dados do SELECT
                var personagem = new Personagem();
                personagem.Id = Convert.ToInt32(registro["id"]);
                personagem.Nome = registro["nome"].ToString();

                // Instanciar a editora para poder armazenar o da editora
                personagem.Editora = new Editora();
                personagem.Editora.Id = Convert.ToInt32(registro["editora_id"]);
                personagem.Editora.Nome = registro["editora_nome"].ToString();

                personagem.TipoPersonagem = new TipoPersonagem();
                personagem.TipoPersonagem.Id = Convert.ToInt32(registro["tipo_personagem_id"]);
                personagem.TipoPersonagem.Tipo = registro["tipo_personagem_tipo"].ToString();

                personagens.Add(personagem);
            }

            return personagens;
        }
    }
}
