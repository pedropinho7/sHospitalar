#region

using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Agenda;
using Agenda.escolherHora.UC_HoraDisponivel;
using Agenda.pesquisarUtente;

#endregion

namespace sHospitalar.NovaConsulta
{
    public partial class NovaConsulta : Form
    {
        public Marcacoes Marcacao = UcHoraDisponivel.marcacao;
        public Utentes utente = PesquisarUtente.utente;
        
        public NovaConsulta()
        {
            InitializeComponent();
        }

        private void NovaConsulta_Load(object sender, EventArgs e)
        {
            nomeBox.Text = utente.Nome;
            IdBox.Text = utente.Id.ToString();
            ageBox.Text = utente.Idade.ToString();
            sexoBox.Text = utente.Sexo.ToString();
            diaBox.Text = Marcacao.Dia.ToString();
            mesBox.Text = Marcacao.Mes.ToString();
            anoBox.Text = Marcacao.Ano.ToString();
            horaBox.Text = Marcacao.Hora.ToString();
        }
    }
}