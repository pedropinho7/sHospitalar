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
            Database.CriarUtente(utenteNameBox.Text, (DateTime.Now.Year - birthdayPicker.Value.Year), sexBox.Text);
            MessageBox.Show($"{utenteNameBox.Text} adicionado aos utentes.");
            this.Close();
        }
    }
}