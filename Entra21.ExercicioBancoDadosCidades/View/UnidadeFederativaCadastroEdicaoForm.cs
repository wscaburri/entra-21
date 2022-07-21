using Entra21.ExercicioBancoDadosCidades.Models;
using Entra21.ExercicioBancoDadosCidades.Services;

namespace Entra21.ExercicioBancoDadosCidades.View
{
    public partial class UnidadeFederativaCadastroEdicaoForm : Form
    {
        private int idEdicao = -1;

        public UnidadeFederativaCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public UnidadeFederativaCadastroEdicaoForm(UnidadeFederativa unidadeFederativa) : this()
        {
            idEdicao = unidadeFederativa.Id;
            textBoxNome.Text = unidadeFederativa.Nome;
            textBoxSigla.Text = unidadeFederativa.Sigla;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var sigla = textBoxSigla.Text.Trim();

            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Nome = nome;
            unidadeFederativa.Sigla = sigla;

            var unidadeFederativaService = new UnidadeFederativaService();

            if (idEdicao == -1)
            {
                unidadeFederativaService.Cadastrar(unidadeFederativa);

                MessageBox.Show("Unidade Federativa cadastrada com sucesso!");

                Close();

                return;
            }

            unidadeFederativa.Id = idEdicao;

            unidadeFederativaService.Editar(unidadeFederativa);

            MessageBox.Show("Unidade Federativa alterada com sucesso!");

            Close();
        }
    }
}