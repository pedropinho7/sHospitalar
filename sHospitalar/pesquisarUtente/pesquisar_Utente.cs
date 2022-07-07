using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using sHospitalar.criarUtente;
using sHospitalar.Data;

namespace sHospitalar.pesquisarUtente
{
    public partial class PesquisarUtente : Form
    {
        public static Utentes utente = new Utentes();

        public PesquisarUtente()
        {
            InitializeComponent();
        }

        public void search_Utente(Utentes utentes)
        {
            var database = new Db();
            DataTable dt = null;
            
            if (String.IsNullOrEmpty((string)utenteIDBox.Text))
            {
                utenteIDBox.Text = "0";
            }

            utentes.Id = int.Parse(utenteIDBox.Text);;

            if (utentes.Id > 0)
            {
                dt = database.MostrarDadosEmGrid(utentes.Id);
            }
            else
            {
                dt = database.MostrarDadosEmGrid(utentes.Nome);
            }

            gridResultadosPesquisa.DataSource = dt;

            // ReSharper disable once PossibleNullReferenceException
            if (dt.Rows.Count == 0)
            {
                var titulo = "Não foram encontrados resultados.";
                var message = "Criar novo _utentes?";
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, titulo, buttons);
                if (result == DialogResult.Yes)
                {
                    new CriarUtente().ShowDialog();
                }
            }
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            search_Utente(utente);
        }

        private void gridResultadosPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            utente.Nome = gridResultadosPesquisa["Nome", gridResultadosPesquisa.CurrentCell.RowIndex]
                .Value.ToString();
            
            gridResultadosPesquisa.Rows[gridResultadosPesquisa.CurrentCell.RowIndex].Selected = true;


            var titulo = "Nova consulta";
            var message = "Criar nova consulta ?";
            var buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, titulo, buttons);


            if (result == DialogResult.Yes)
            {
                var agenda = new Agenda.Agenda();
                agenda.Show();
                this.Close();
            }
        }

        private void utenteNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_Utente(utente);
            }
        }

        private void utenteIDBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_Utente(utente);
            }
        }
    }
}