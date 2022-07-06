using System;
using System.Windows.Forms;
using Data;

namespace sHospitalar
{
    public partial class Criar_Utente : Form
    {
        public Criar_Utente()
        {
            InitializeComponent();
        }

        private void criarUtenteButton_Click(object sender, EventArgs e)
        {
            db Database = new db();
            if (!string.IsNullOrEmpty(utenteNameBox.Text) && !string.IsNullOrEmpty(sexBox.Text))
            {
            Database.CriarUtente(utenteNameBox.Text, (DateTime.Now.Year - birthdayPicker.Value.Year), sexBox.Text);
            MessageBox.Show($"Criado utente {utenteNameBox.Text}.");
            this.Close();
            }
            else
            {
                MessageBox.Show("Dados inválidos. Pf confirma todos os dados antes de submeter novo utente.");
            }
        }
    }
}