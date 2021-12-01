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
    public partial class frmPistas : Form
    {
        OpenFileDialog ofdFoto = new OpenFileDialog();
        public frmPistas()
        {
            InitializeComponent();
        }

        private void pistasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);

        }

        private void pistasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);

        }

        private void frmPistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clubraquetaDataSet.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.clubraquetaDataSet.pistas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdFoto.Filter = "image files|*.jpg;*png;*.gif;*.ico;.*;";
            if (ofdFoto.ShowDialog() == DialogResult.OK) fotoPictureBox.Image = Image.FromFile(ofdFoto.FileName);
        }
    }
}
