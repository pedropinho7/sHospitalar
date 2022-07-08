#region

using System;
using System.Data;
using System.Windows.Forms;
using Agenda.criarUtente;
using Agenda.Data;

#endregion

namespace Agenda.pesquisarUtente
{
    public partial class PesquisarUtente : Form
    {
        public static Utentes utente = Db.utente;

        public PesquisarUtente()
        {
            InitializeComponent();
        }

        public void search_Utente()
        {
            var database = new Db();
            DataTable dt;

            if (!string.IsNullOrEmpty(utenteIDBox.Text) && int.TryParse(utenteIDBox.Text, out _))
            {
                dt = database.MostrarDadosEmGrid(int.Parse(utenteIDBox.Text));
                gridResultadosPesquisa.DataSource = dt;
            }
            else
            {
                dt = database.MostrarDadosEmGrid(utenteNameBox.Text);
                gridResultadosPesquisa.DataSource = dt;
            }

            if (dt.Rows.Count == 0)
            {
                var titulo = "Não foram encontrados resultados.";
                var message = "Criar novo utente?";
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, titulo, buttons);
                if (result == DialogResult.Yes) new CriarUtente().ShowDialog();
            }
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            search_Utente();
        }

        private void gridResultadosPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gridResultadosPesquisa.Rows[gridResultadosPesquisa.CurrentCell.RowIndex].Selected = true;
            var titulo = "Nova consulta";
            var message = "Criar nova consulta ?";
            var buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, titulo, buttons);


            if (result == DialogResult.Yes)
            {
                var agenda = new sHospitalar.Agenda();
                agenda.Show();
                Close();
            }
        }

        private void utenteNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) search_Utente();
        }

        private void utenteIDBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) search_Utente();
        }
    }
}