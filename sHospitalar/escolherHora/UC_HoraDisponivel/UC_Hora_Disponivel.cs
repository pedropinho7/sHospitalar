#region

using System;
using System.Windows.Forms;
using sHospitalar.NovaConsulta;

#endregion

namespace Agenda.escolherHora.UC_HoraDisponivel
{
    public partial class UcHoraDisponivel : UserControl
    {
        public static Marcacoes marcacao = sHospitalar.Agenda.marcacao;

        public UcHoraDisponivel()
        {
            
            InitializeComponent();
        }

        public void Horas(int horaInicio, int horaFim)
        {
            var primeiraHora = horaInicio <= 9 ? "0" + horaInicio : horaInicio.ToString();

            if (primeiraHora == null) throw new ArgumentNullException(nameof(primeiraHora));

            var segundaHora = horaFim <= 9 ? "0" + horaFim : horaFim.ToString();

            primeiraHoraLabel.Text = primeiraHora;
            segundaHoraLabel.Text = segundaHora;
        }

        private void primeiraHoraLabel_Click(object sender, EventArgs e)
        {
            marcacao.Hora = Int32.Parse(primeiraHoraLabel.Text);
            var novaconsulta = new NovaConsulta();
            novaconsulta.Show();        }

        private void labelDelimitador_Click(object sender, EventArgs e)
        {
            marcacao.Hora = Int32.Parse(primeiraHoraLabel.Text);
            var novaconsulta = new NovaConsulta();
            novaconsulta.Show();        }

        private void segundaHoraLabel_Click(object sender, EventArgs e)
        {
            marcacao.Hora = Int32.Parse(primeiraHoraLabel.Text);
            var novaconsulta = new NovaConsulta();
            novaconsulta.Show();        }
    }
}