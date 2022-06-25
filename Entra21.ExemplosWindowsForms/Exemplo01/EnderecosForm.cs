using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;
        private PacienteServico pacienteServico;

        // Construtor: construir o objeto que está sendo instanciado com as devidas informações ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            // Instanciado o objeto de PacienteServico o permitirá listar os pacientes no ComboBox
            // e decorente disso será possível o usuário selecionar o mesmo
            pacienteServico = new PacienteServico();

            // Deve apresentar os dados quando a tela for carregada
            PreencherDataGridViewComEnderecos();

            // Irá preencher o ComboBox(campo de seleção) com os pacientes
            PreencherComboBoxComOsNomesDosPacientes();

            ObterDadosCep();
        }

        private void PreencherComboBoxComOsNomesDosPacientes()
        {
            // Obter lista dos pacientes que foram cadastrados (armazenados no JSON)
            var pacientes = pacienteServico.ObterTodos();

            // Percorrer todos os pacientes adicionando no ComboBox
            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;

            dataGridView1.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuário armazenando em variáveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            // Executar o método ValidarDados que retornará um bool
            // Sendo true quando os dados forem válidos, false quando os dados forem inválidos
            var dadosValidos = ValidarDados(cep, enderecoCompleto, nomePaciente);

            // Verifica se os dados são inválidos para não continuidade no cadastro de endereço
            if (dadosValidos == false)
            {
                return;
            }

            // Verificar se não está em modo de edição, ou seja, modo de cadastro
            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarEndereco(cep, enderecoCompleto, nomePaciente);
            else
                EditarEndereco(cep, enderecoCompleto, nomePaciente);

            // Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();

            LimparCampos();
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string nomePaciente)
        {
            // Obter linha selecionada
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter código que está na linha oculta do DataGridView
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Construir o objeto com os dados da tela
            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Atualizar o dado na lista de endereços e salvar o dado atualizado no arquivo JSON
            enderecoServico.Editar(endereco);
        }

        private void CadastrarEndereco(string cep, string enderecoCompleto, string? nomePaciente)
        {
            // Construir o objeto de endereço com as variáveis
            var endereco = new Endereco();
            endereco.Codigo = enderecoServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            // Salvar este endereço na lista de endereços e no arquivo JSON
            enderecoServico.Adicionar(endereco);
        }

        private void PreencherDataGridViewComEnderecos()
        {
            // Obter todos os endereços da lista de endereços
            var enderecos = enderecoServico.ObterTodos();

            // Remove todas as linhas do dataGridView
            dataGridView1.Rows.Clear();

            // Percorrer cada um dos endereços adicionando uma nova linha na tabela
            for (var i = 0; i < enderecos.Count; i++)
            {
                // Obter endereco percorrido
                var endereco = enderecos[i];

                // Cria uma nova linha no DataGridView com os dados referentes ao endereço
                dataGridView1.Rows.Add(new object[] {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });
            }

            // Remove a seleção do dataGridView
            dataGridView1.ClearSelection();
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
            {
                return;
            }

            // HttpClient permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisição para o site ViaCep para obter os dados do endereço do cep
            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            // Verificar se a requisição deu certo{
            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Obter a resposta da requisição
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text =
                    $"{ dadosEndereco.Uf } - { dadosEndereco.Localidade } - { dadosEndereco.Bairro } - { dadosEndereco.Logradouro }";
            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        // Será executado este método quando o usuário sair do campo de cep

        private bool ValidarDados(string cep, string enderecoCompleto, string nomePaciente)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP Inválido");

                maskedTextBoxCep.Focus();

                return false;
            }

            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("Endereço Complelto deve ter no mínimo 10 caracteres");

                textBoxEnderecoCompleto.Focus();

                return false;
            }

            if (comboBoxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um pacitente");

                comboBoxPaciente.DroppedDown = true;

                return false;
            }

            return true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Verificar se algum item do DataGridView está selecionado
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover");

                return;
            }

            // Questionar se o usuário realmente deseja apagar
            var resposta = MessageBox.Show(
                "Deseja realmente apagar o endereço", "Aviso",
                MessageBoxButtons.YesNo);

            // Validar que o usuário não escolheu Sim, pq não deverá continuar executando o código abaixo
            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Seu registro está salvo");

                return;
            }

            // Qual item será apagado
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter o código da linha selecionada na primeira coluna, que não está sendo apresentadda para o usuário, que é referente ao código de endereço
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Apagar o item da lista de itens no serviço
            // Atualizar o arquivo JSON

            // Buscar o endereço da lista de endereços filtrando por código
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            // Apagar o endereço encontrado da lista de endereços e atualizar o arquivo JSON
            enderecoServico.Apagar(endereco);

            // Atualizar o DataGridView
            PreencherDataGridViewComEnderecos();

            // Remover a seleção do DataGridView
            dataGridView1.ClearSelection();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para editar");

                return;
            }

            // Obter a linha que o usuário selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter o código do endereço que o usuário selecionou
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Obter endereço escolhido
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            // Apresentar os dados do endereço na tela para edição
            maskedTextBoxCep.Text = endereco.Cep;
            textBoxEnderecoCompleto.Text = endereco.EnderecoCompleto;
            comboBoxPaciente.SelectedItem = endereco.Paciente.Nome;
        }

        private void EnderecosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }
    }
}