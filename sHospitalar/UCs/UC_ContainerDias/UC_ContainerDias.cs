using System;
using System.Windows.Forms;

namespace sHospitalar
{

    public partial class UC_ContainerDias : UserControl
    {
        public static int static_day;
        public UC_ContainerDias()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            labelDiaTexto.Text = numday.ToString();
        }

        private void UC_ContainerDias_Click(object sender, EventArgs e)
        {
            static_day = Convert.ToInt32(labelDiaTexto.Text);
            criar_Consulta criarConsulta = new criar_Consulta();
            criarConsulta.ShowDialog();
        }

    }
}