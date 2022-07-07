using System;
using System.Windows.Forms;
using sHospitalar.escolherHora;

namespace sHospitalar.Agenda.UCs.UC_ContainerDia
{

    public partial class UcContainerDia : UserControl
    {
        public Marcacoes marcacao = Agenda.marcacao;
        
        public UcContainerDia()
        {
            InitializeComponent();
        }

        public void Days(int numday)
        {
            this.labelDiaTexto.Text = numday.ToString();
        }

        public void MostrarHora()
        {
            marcacao.Dia = Convert.ToInt32(labelDiaTexto.Text); 
            var escolherHora = new EscolherHora();
            escolherHora.Show();
        }
        private void UcContainerDia_Click(object sender, EventArgs e)
        {
            this.MostrarHora();
        }

        private void labelDiaTexto_Click(object sender, EventArgs e)
        {
            this.MostrarHora();
        }
    }
}