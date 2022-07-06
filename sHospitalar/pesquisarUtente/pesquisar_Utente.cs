using System;
using System.Data;
using System.Windows.Forms;
using Data;

namespace sHospitalar
{
    public partial class pesquisar_Utente : Form
    {
        public static int static_ID;
        public pesquisar_Utente()
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

        private void gridResultadosPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             int indexID = gridResultadosPesquisa.CurrentCell.RowIndex;
             gridResultadosPesquisa.Rows[indexID].Selected = true;
             var teste = gridResultadosPesquisa[0, indexID].Value;
             int ID = (int)teste;
             static_ID = ID;

             string titulo = "Nova consulta";
             string message = "Criar novaconsulta ?";
                         
             
             MessageBoxButtons buttons = MessageBoxButtons.YesNo;
             var result = MessageBox.Show(message, titulo, buttons);
             if (result == DialogResult.Yes)
             {
                 DatasDisponiveis datasDisponiveis = new DatasDisponiveis();
                 datasDisponiveis.Show();
                 this.Close();
             }
        }
    }
}