namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonEnderecos_Click(object sender, EventArgs e)
        {
            var enderecosForm = new EnderecosForm();
            enderecosForm.ShowDialog();
        }

        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            var pacientesForm = new PacientesForm();
            pacientesForm.ShowDialog();
        }
    }
}