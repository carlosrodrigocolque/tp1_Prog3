using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace trabajoPractico_1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            formEj1 ventana = new formEj1();
            ventana.Show();
            
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            formEj2 ventana = new formEj2();
            ventana.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            formEj3 ventana = new formEj3();
            ventana.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblIntegrantes.Text = "Integrantes: ";
            lblIntegrante1.Text = "1";
            lblIntegrante2.Text = "2";
            lblIntegrante3.Text = "3";
            lblIntegrante4.Text = "4";
            lblIntegrante5.Text = "5";

        }
    }
}
