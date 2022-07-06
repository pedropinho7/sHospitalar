using System;
using System.Linq;
using System.Windows.Forms;
using sHospitalar.Agenda.UCs.UC_ContainerDia;
using sHospitalar.Agenda.UCs.UC_ContainerDiaBranco;
using sHospitalar.escolherHora;
using sHospitalar.escolherHora.UCs;
using sHospitalar.pesquisarUtente;

namespace sHospitalar.Agenda
{
    public partial class Agenda : Form
    {
        public int Month;
        public int Year;
        public static int static_month, static_year;
        
        public Agenda()
        {
            InitializeComponent();
        }

        private void datas_disponiveis_Load(object sender, EventArgs e)
        {

            var now = DateTime.Now;
            Month = now.Month;
            Year = now.Year;
            MostrarDias(Month, Year);
        }

        public void CloseAgenda()
        {
            this.Close();
        }
        
        
        private void MostrarDias(int month, int year)
        {
            static_month = month;
            static_year = year;
            dayContainer.Controls.Clear();
            var nomeMesExtenso = new DateTime(year, month, 1).ToString("MMMM");
            
            
            nomeMesExtenso = char.ToUpper(nomeMesExtenso[0]) + nomeMesExtenso.Substring(1);

            labelMesAno.Text = nomeMesExtenso + " " + year;
            
            var inicioMes = new DateTime(year, month, 1);

            var totalDiasDoMes = DateTime.DaysInMonth(year, month);

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
            if (Month != 1)
            {
                Month--;
            }
            else
            {
                Month = 12;
                Year--;
            }
            MostrarDias(Month, Year);
        }

        private void seguinteButton_Click(object sender, EventArgs e)
        {
            if (Month != 12)
            {
                Month++;
            }
            else
            {
                Month = 1;
                Year++;
            }
            MostrarDias(Month, Year);
        }

        private void Agenda_FormClosed(object sender, FormClosedEventArgs e)
        {

            var pesquisar_utente = new PesquisarUtente();
            pesquisar_utente.Show();

        }
    }
}