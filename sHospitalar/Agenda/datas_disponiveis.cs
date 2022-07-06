using System;
using System.Windows.Forms;

namespace sHospitalar
{
    public partial class DatasDisponiveis : Form
    {
        int month, year;
        public static int static_month, static_year;
        
        public DatasDisponiveis()
        {
            InitializeComponent();
        }

        private void datas_disponiveis_Load(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            MostrarDias(month, year);
        }

        private void MostrarDias(int month, int year)
        {
            static_month = month;
            static_year = year;
            dayContainer.Controls.Clear();
            string nomeMesExtenso = new DateTime(year, month, 1).ToString("MMMM");
            
            
            nomeMesExtenso = char.ToUpper(nomeMesExtenso[0]) + nomeMesExtenso.Substring(1);

            labelMesAno.Text = nomeMesExtenso + " " + year;
            
            DateTime inicioMes = new DateTime(year, month, 1);

            int totalDiasDoMes = DateTime.DaysInMonth(year, month);

            int diaDaSemana = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d"));
            
            for (int i = 0; i < diaDaSemana; i++)
            {
                UC_ContinainerBranco ucblank = new UC_ContinainerBranco();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= totalDiasDoMes; i++)
            {
                UC_ContainerDias ucdays = new UC_ContainerDias();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void anteriorButton_Click(object sender, EventArgs e)
        {
            if (month != 1)
            {
                month--;
            }
            else
            {
                month = 12;
                year--;
            }
            MostrarDias(month, year);
        }

        private void seguinteButton_Click(object sender, EventArgs e)
        {
            if (month != 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }
            MostrarDias(month, year);

        }
    }
}