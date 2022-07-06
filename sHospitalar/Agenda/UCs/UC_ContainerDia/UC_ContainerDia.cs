using System;
using System.Windows.Forms;
using sHospitalar.escolherHora;

namespace sHospitalar.Agenda.UCs.UC_ContainerDia
{

    public partial class UcContainerDia : UserControl
    {
        public static int StaticDay;
        public UcContainerDia()
        {
            InitializeComponent();
        }

        public void Days(int numday)
        {
            labelDiaTexto.Text = numday.ToString();
        }

        private void UC_ContainerDias_Click(object sender, EventArgs e)
        {
            StaticDay = Convert.ToInt32(labelDiaTexto.Text); 
            var novaConsulta = new EscolherHora();
            novaConsulta.Show();
        }

    }
}