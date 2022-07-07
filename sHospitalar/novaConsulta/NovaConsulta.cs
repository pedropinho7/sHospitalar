using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using sHospitalar.Agenda.UCs.UC_ContainerDia;
using sHospitalar.Data;
using sHospitalar.escolherHora;
using sHospitalar.escolherHora.UCs;
using sHospitalar.pesquisarUtente;

namespace sHospitalar.NovaConsulta
{
    public partial class NovaConsulta : Form
    {
        public Utentes utente = PesquisarUtente.utente;
        public Marcacoes Marcacao = UcHoraDisponivel.marcacao;
        public NovaConsulta()
        {
            InitializeComponent();
            string message =
                $"O utente {utente.Nome}, com o ID {utente.Id} tem consulta dia {Marcacao.Dia}-{Marcacao.Mes}-{Marcacao.Ano} às {Marcacao.Hora} horas.";
            labeTeste.Text = message;
            
            //SEEMS WORKING, CONTINUAR AMANHA.
        }



        private void labelID_TextChanged(object sender, EventArgs e)
        {
            nomeBox.Text = utente.Nome;
        }



        /*private void labelID_TextChanged(object sender, EventArgs e)
        {
            this.nomeBox.Clear();
            this.nomeBox.Text = GetUtenteName();
        }*/
    }
}