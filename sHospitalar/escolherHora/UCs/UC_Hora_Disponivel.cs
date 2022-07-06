using System;
using System.Windows.Forms;

namespace sHospitalar.escolherHora.UCs
{
    public partial class UcHoraDisponivel : UserControl
    {
        public UcHoraDisponivel()
        {
            InitializeComponent();
        }

        public void Horas(int horaInicio, int horaFim)
        {
            var primeiraHora = horaInicio <= 9 ? "0" + horaInicio.ToString() : horaInicio.ToString();
            var segundaHora = horaFim <= 9 ? "0" + horaFim.ToString() : horaFim.ToString();
            labelHoraHora.Text = $@"{primeiraHora}h - {segundaHora}h";
        }

        private void UcHoraDisponivel_Click(object sender, EventArgs e)
        {
            
        }
    }

}
