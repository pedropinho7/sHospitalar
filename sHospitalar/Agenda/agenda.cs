#region

using System;
using System.Windows.Forms;
using Agenda;
using Agenda.pesquisarUtente;
using sHospitalar.UCs.UC_ContainerDia;
using sHospitalar.UCs.UC_ContainerDiaBranco;

#endregion

namespace sHospitalar
{
    public partial class Agenda : Form
    {
        public static Marcacoes marcacao = new Marcacoes();

        public Agenda()
        {
            InitializeComponent();
        }

        private void datas_disponiveis_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            marcacao.Mes = now.Month;
            marcacao.Ano = now.Year;
            MostrarDias();
        }

        public void CloseAgenda()
        {
            Close();
        }


        private void MostrarDias()
        {
            dayContainer.Controls.Clear();
            var nomeMesExtenso = new DateTime(marcacao.Ano, marcacao.Mes, 1).ToString("MMMM");


            nomeMesExtenso = char.ToUpper(nomeMesExtenso[0]) + nomeMesExtenso.Substring(1);

            labelMesAno.Text = nomeMesExtenso + " " + marcacao.Ano;

            var inicioMes = new DateTime(marcacao.Ano, marcacao.Mes, 1);

            var totalDiasDoMes = DateTime.DaysInMonth(marcacao.Ano, marcacao.Mes);

            var diaDaSemana = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d"));

            for (var i = 0; i < diaDaSemana; i++)
            {
                var ubBranco = new UcContainerBranco();
                dayContainer.Controls.Add(ubBranco);
            }

            for (var i = 1; i <= totalDiasDoMes; i++)
            {
                var ucdays = new UcContainerDia();
                ucdays.Days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void anteriorButton_Click(object sender, EventArgs e)
        {
            if (marcacao.Mes != 1)
            {
                marcacao.Mes--;
            }
            else
            {
                marcacao.Mes = 12;
                marcacao.Ano--;
            }

            MostrarDias();
        }

        private void seguinteButton_Click(object sender, EventArgs e)
        {
            if (marcacao.Mes != 12)
            {
                marcacao.Mes++;
            }
            else
            {
                marcacao.Mes = 1;
                marcacao.Ano++;
            }

            MostrarDias();
        }

        private void Agenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            var pesquisarUtente = new PesquisarUtente();
            pesquisarUtente.Show();
        }
    }
}