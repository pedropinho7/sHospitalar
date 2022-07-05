using System;
using System.Data;
using System.Windows.Forms;
using Data;

namespace sHospitalar
{
    public partial class Criar_consulta : Form
    {
        public Criar_consulta()
        {
            InitializeComponent();
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            db Database = new db();
            DataTable dt = null;
            if (String.IsNullOrEmpty(utenteIDBox.Text))
            { 
                dt = Database.PesquisarUtentePorNome(gridResultadosPesquisa, utenteNameBox.Text);
            }
            else if (!String.IsNullOrEmpty(utenteIDBox.Text))
            {
                dt = Database.PesquisarUtentePorID(gridResultadosPesquisa, utenteIDBox.Text);
            }

            gridResultadosPesquisa.DataSource = dt;
            

            if (dt.Rows.Count == 0)
            {
                string titulo = "Não foram encontrados resultados.";
                string message = "Criar novo utente?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, titulo, buttons);
                if (result == DialogResult.Yes)
                {
                    new Criar_Utente().ShowDialog();
                }
            }

        }
    }
}