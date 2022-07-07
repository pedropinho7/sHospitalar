using System;
using System.Windows.Forms;

namespace sHospitalar.escolherHora.UCs
{
    public partial class UcHoraDisponivel : UserControl
    {
        public static Marcacoes marcacao = Agenda.Agenda.marcacao;

        public UcHoraDisponivel()
        {
            InitializeComponent();
        }

        public void Horas(int horaInicio, int horaFim)
        {
            var _primeiraHora = horaInicio <= 9 ? "0" + horaInicio.ToString() : horaInicio.ToString();
            var _segundaHora = horaFim <= 9 ? "0" + horaFim.ToString() : horaFim.ToString();
            marcacao.Hora = Convert.ToInt32(_primeiraHora);
            labelHoraHora.Text = $@"{_primeiraHora}h - {_segundaHora}h";
        }

        private void labelHoraHora_Click(object sender, EventArgs e)
        {
            var novaconsulta = new NovaConsulta.NovaConsulta();
            novaconsulta.Show();
        }
    }
}