using System;
using System.Windows.Forms;

namespace sHospitalar
{
    public partial class UC_ContainerDias : UserControl
    {
        public UC_ContainerDias()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            labelDiaTexto.Text = numday.ToString();
        }
    }
}