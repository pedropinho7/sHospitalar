using System;
using System.Windows.Forms;
using sHospitalar.escolherHora.UCs;

namespace sHospitalar.escolherHora
{
    public partial class EscolherHora : Form
    {
        public EscolherHora()
        {
            InitializeComponent();
        }

        private void MostrarHoras()
        {
            var x = 9;
            for (var i = 8; i < 19; i++)
            {
                var horaDisponivel = new UcHoraDisponivel();
                horaDisponivel.Horas(i, x);
                flowLayoutPanel1.Controls.Add(horaDisponivel);
                x++;
            }
        }

        private void nova_Consulta_Load(object sender, EventArgs e)
        {
            MostrarHoras();
        }

        public void EscolherHora_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
