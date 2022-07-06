using System;
using System.Data;
using System.Windows.Forms;
using sHospitalar.criarUtente;
using sHospitalar.Data;

namespace sHospitalar.pesquisarUtente
{
    public partial class PesquisarUtente : Form
    {
        public static int StaticId;
        public PesquisarUtente()
        {
            InitializeComponent();
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            Db database = new Db();
            DataTable dt = null;
            if (string.IsNullOrEmpty(utenteIDBox.Text))
            {
                dt = database.PesquisarUtentePorNome(gridResultadosPesquisa, utenteNameBox.Text);
            }
            else if (!string.IsNullOrEmpty(utenteIDBox.Text))
            {
                dt = database.PesquisarUtentePorId(gridResultadosPesquisa, utenteIDBox.Text);
            }

            gridResultadosPesquisa.DataSource = dt;


            if (dt.Rows.Count == 0)
            {
                var titulo = "Não foram encontrados resultados.";
                var message = "Criar novo utente?";
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, titulo, buttons);
                if (result == DialogResult.Yes)
                {
                    new CriarUtente().ShowDialog();
                }
            }
        }

        private void gridResultadosPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             var indexId = gridResultadosPesquisa.CurrentCell.RowIndex;
             gridResultadosPesquisa.Rows[indexId].Selected = true;
             var teste = gridResultadosPesquisa[0, indexId].Value;
             int id = (int)teste;
             StaticId = id;

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
    }
}