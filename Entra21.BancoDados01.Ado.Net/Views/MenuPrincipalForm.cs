using Entra21.BancoDados01.Ado.Net.Views.Personagens;
using Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonEditoras_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPersonagens_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemListagemForm();
            personagemForm.ShowDialog();
        }

        private void buttonTipoPersonagens_Click(object sender, EventArgs e)
        {
            var tipoPersonagemForm = new TipoPersonagemListagemForm();
            tipoPersonagemForm.ShowDialog();
        }
    }
}
