using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaAntonioPerez
{
    public partial class frmAdministrar : Form
    {
        public frmAdministrar()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPistas pistas = new frmPistas();
            pistas.Show();
        }
         private void frmAdministrar_Load(object sender, EventArgs e)
        {
           
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservas reserva = new frmReservas();
            reserva.MdiParent = this;
            reserva.Dock = DockStyle.Fill;
            reserva.Show();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSocios ventanaSocio = new frmSocios();
            ventanaSocio.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes informe = new frmInformes();
            informe.Show();
        }
    }
}
