#region

using System;
using System.Windows.Forms;
using Agenda.pesquisarUtente;

#endregion

namespace Agenda.MainPage
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CriarConsultaButton_Click(object sender, EventArgs e)
        {
            var pesquisarUtente = new PesquisarUtente();
            pesquisarUtente.Show();
            Hide();
        }
    }
}