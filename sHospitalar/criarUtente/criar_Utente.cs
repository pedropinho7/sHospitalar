using System;
using System.Windows.Forms;
using sHospitalar.Data;

namespace sHospitalar.criarUtente
{
    public partial class CriarUtente : Form
    {
        public CriarUtente()
        {
            InitializeComponent();
        }

        private void criarUtenteButton_Click(object sender, EventArgs e)
        {
            var database = new Db();
            if (!string.IsNullOrEmpty(utenteNameBox.Text) && !string.IsNullOrEmpty(sexBox.Text))
            {
            database.CriarUtente(utenteNameBox.Text, (DateTime.Now.Year - birthdayPicker.Value.Year), sexBox.Text);
            MessageBox.Show($@"Criado utente {utenteNameBox.Text}.");
            this.Close();
            }
            else
            {
                MessageBox.Show(@"Dados inválidos. Pf confirma todos os dados antes de submeter novo utente.");
            }
        }
    }
}