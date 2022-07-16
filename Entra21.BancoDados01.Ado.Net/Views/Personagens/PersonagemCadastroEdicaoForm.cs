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

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemCadastroEdicaoForm : Form
    {
        public PersonagemCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxTipoPersonagem();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if(comboBoxEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Seleciona uma Editora");
                return;
            }

            if(comboBoxTipoPersonagem.SelectedIndex == -1)
            {
                MessageBox.Show("Seleciona um Tipo de Personagem");
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var tipoPersonagem = comboBoxTipoPersonagem.SelectedItem as TipoPersonagem;
            var editora = comboBoxEditora.SelectedItem as Editora;

            var personagem = new Personagem();
            personagem.Nome = nome;
            personagem.TipoPersonagem = tipoPersonagem;
            personagem.Editora = editora;

            // Persistir o que o usuario escolheu na tabela de personagens
            var personagemService = new PersonagemService();
            personagemService.Cadastrar(personagem);

            MessageBox.Show("Personagem cadastrado com sucesso");
            Close();
        }

        private void PreencherComboBoxTipoPersonagem()
        {
            // Buscar todos os tipos de personagens no banco de dados para permitir o usuario escolher
            var tipoPersonagemService = new TipoPersonagemService();
            var tipoPersonagens = tipoPersonagemService.ObterTodos();

            for (int i = 0; i < tipoPersonagens.Count; i++)
            {
                var tipoPersonagem = tipoPersonagens[i];
                comboBoxTipoPersonagem.Items.Add(tipoPersonagem);
            }
        }
    }
}
