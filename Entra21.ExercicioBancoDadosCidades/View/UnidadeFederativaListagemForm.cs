using Entra21.ExercicioBancoDadosCidades.Services;

namespace Entra21.ExercicioBancoDadosCidades.View
{
    public partial class UnidadeFederativaListagemForm : Form
    {
        private UnidadeFederativaService unidadeFederativaService;

        public UnidadeFederativaListagemForm()
        {
            InitializeComponent();

            unidadeFederativaService = new UnidadeFederativaService();
        }

        private void AtualizarRegistrosDataGridView()
        {
            var unidadesFederativas = unidadeFederativaService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    unidadeFederativa.Id,
                    unidadeFederativa.Nome,
                    unidadeFederativa.Sigla
                });
            }
        }

        private void UnidadeFederativaListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var unidadeFederativaCadastroEdicaoForm = new UnidadeFederativaCadastroEdicaoForm();

            unidadeFederativaCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            unidadeFederativaService.Apagar(id);

            AtualizarRegistrosDataGridView();

            MessageBox.Show("Unidade Federativa apagada com sucesso!");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre alguma Unidade Federativa!");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione alguma Unidade Federativa!");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var unidadeFederativa = unidadeFederativaService.ObterPorId(id);

            var unidadeFederativaForm = new UnidadeFederativaCadastroEdicaoForm(unidadeFederativa);

            // apresentado o form para o usuário
            unidadeFederativaForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }
    }
}