using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private List<Paciente> pacientes;

        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;

        public PacientesForm()
        {
            InitializeComponent();

            // Cria uma lista de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();

            // Ler do arquivo json os pacientes cadastrados anteriormente
            LerArquivoApresentandoPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            // Calcular Imc
            var imc = CalcularImc(peso, altura);

            // Verifica se está em modo de adição
            if (indiceLinhaSelecionada == -1)
            {
                // Adicionar linha no dataGridView de pacientes
                dataGridView1.Rows.Add(new object[]
                {
                ++codigo, nome, altura, peso, imc
                });

                AdicionarPacienteSalvandoNoArquivo(codigo, nome, peso, altura);

                return;
            }

            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

            EditarDados(nome, peso, altura);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um Paciente");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Verifica se o usuário escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                // Remove a linha utilizando o indice do DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);

                // Remove o paciente da lista de pacientes
                pacientes.RemoveAt(indiceLinhaSelecionada);

                // Atualiza o arquivo com lista de pacientes sem o paciente removido
                SalvarEmArquivo();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            // Obter a linha que o usuario selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter a informação da linha selecionada passando a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[indiceLinhaSelecionada].Nome = nome;
            pacientes[indiceLinhaSelecionada].Peso = peso;
            pacientes[indiceLinhaSelecionada].Altura = altura;

            SalvarEmArquivo();

            LimparCampos();
        }

        private void AdicionarPacienteSalvandoNoArquivo(int codigo, string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = codigo,
                Nome = nome,
                Peso = peso,
                Altura = altura,
            };

            //var paciente = new Paciente
            //paciente.Codigo = codigo;
            //paciente.Nome = nome;

            pacientes.Add(paciente);

            SalvarEmArquivo();
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxPeso.Text = "";
            textBoxNome.Text = "";
            textBoxAltura.Text = "";

            indiceLinhaSelecionada = -1;

            dataGridView1.ClearSelection();
        }

        private void SalvarEmArquivo()
        {
            // Converter uma lista de objetos em uma string contendo o json
            var pacientesEmJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.json";
            // Salvar a string contendo o json em um arquivo no formato json
            File.WriteAllText(caminho, pacientesEmJson);
        }

        private void LerArquivoApresentandoPacientes()
        {
            // Validar se arquivo não existe, consequentemente não é necessário percorrer uma lista que não existe
            if (File.Exists("pacientes.json") == false)
                return;

            // ler arquivo json e armazenar os pacientes na lista de pacientes
            var conteudoArquivo = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);

            // cria uma variavel para armazenar o código do ultimo produto, para quando cadastrar um novo, armazenar com o código correto
            var maiorCodigo = int.MinValue;

            // Percorre a lista de pacientes
            for (int i = 0; i < pacientes.Count; i++)
            {
                // Obtem o paciente que está sendo percorrido
                var paciente = pacientes[i];

                // Adicionar o paciente que estava em arquivo json no DataGridView
                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo, paciente.Nome,
                    paciente.Altura, paciente.Peso,
                    CalcularImc(paciente.Peso, paciente.Altura)
                });

                // Rotina para descobrir o paciente com o maior código
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;
            }

            // Validar se conseguiu encontrar algum código, caso contrário não deve atualizar o código do novo paciente
            if (maiorCodigo != int.MinValue)
                codigo = maiorCodigo;
        }

        private double CalcularImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }
    }

}
