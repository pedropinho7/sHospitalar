#region

using System;
using System.Windows.Forms;
using Agenda.Data;
using Agenda.pesquisarUtente;

#endregion

namespace Agenda.criarUtente
{
    public partial class CriarUtente : Form
    {
        private readonly Utentes _utentes = PesquisarUtente.utente;

        public CriarUtente()
        {
            InitializeComponent();
        }

        private void criarUtenteButton_Click(object sender, EventArgs e)
        {
            var database = new Db();
            if (!string.IsNullOrEmpty(utenteNameBox.Text) && !string.IsNullOrEmpty(sexBox.Text))
            {
                _utentes.Nome = utenteNameBox.Text;
                _utentes.Idade = DateTime.Now.Year - birthdayPicker.Value.Year;
                _utentes.Sexo = Convert.ToChar(sexBox.Text);
                database.CriarUtente(_utentes);
                MessageBox.Show($@"Criado _utentes {_utentes.Nome}.");
                Close();
            }
            else
            {
                MessageBox.Show(@"Dados inválidos. Pf confirma todos os dados antes de submeter novo _utentes.");
            }
        }
    }
}