using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sHospitalar
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CriarConsultaButton_Click(object sender, EventArgs e)
        {
            Criar_consulta criarConsulta = new Criar_consulta();
            criarConsulta.Show();
            this.Hide();
        }
    }
}