using System;
using System.Windows.Forms;


// NAO ESTÁ A SER USADO PRA JÁ 
namespace sHospitalar
{
    public partial class criar_Consulta : Form
    {
        public criar_Consulta()
        {
            InitializeComponent();
        }

        private void criar_Consulta_Load(object sender, EventArgs e)
        {
            int IDutente = pesquisar_Utente.static_ID;
            int dia = UC_ContainerDias.static_day;
            int mes = DatasDisponiveis.static_month;
            int ano = DatasDisponiveis.static_year;
            string message = $"Utente : {IDutente}\nData: {dia}/{mes}/{ano}";
            MessageBox.Show(message);
        }
    }
}