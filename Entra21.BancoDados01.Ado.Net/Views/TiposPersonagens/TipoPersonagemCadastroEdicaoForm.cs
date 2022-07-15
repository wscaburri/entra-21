using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemCadastroEdicaoForm : Form
    {
        // Armazenar o id do tipo de personagem para permitir a edição
        private int idEdicao = -1;

        public TipoPersonagemCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public TipoPersonagemCadastroEdicaoForm(TipoPersonagem tipoPersonagem) : this()
        {
            // Definido o valor do idEdicao para posteriormente saber qual registro deve ser alterado
            idEdicao = tipoPersonagem.Id;

            // Preenchido o campo do tipo com o valor do banco de dados
            textBoxTipo.Text = tipoPersonagem.Tipo;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = textBoxTipo.Text.Trim();

            var tipoPersonagem = new TipoPersonagem();
            tipoPersonagem.Tipo = tipo;

            // Instancia do objeto de TipoPersonagemService que permitirá persistir o registro
            var tipoPersonagemService = new TipoPersonagemService();

            // Verifica se está em modo cadastro
            if (idEdicao == -1)
            {
                // Persistir a informação na tabela de tipos_personagens
                tipoPersonagemService.Cadastrar(tipoPersonagem);

                MessageBox.Show("Tipo de personagem cadastrado com sucesso");

                Close();

                return;
            }   
            
            tipoPersonagem.Id = idEdicao;
            // Atualizar a informação na tabela de tipos_personagens
            tipoPersonagemService.Editar(tipoPersonagem);

            MessageBox.Show("Tipo de personagem alterado com sucesso!");

            Close();
        }
    }
}
