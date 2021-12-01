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
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //queryCategorias
                var qDni = from c in objBD.socios
                           where c.DNI.ToUpper().Equals(txbDni.Text.ToUpper())
                           select new { c.nombre, c.apellidos, c.domicilio, c.telefono, c.email, c.cuentaCorriente };
                //o c.loquesea
                var listaSocio = qDni.ToList();

                if (listaSocio.Count > 0)
                {
                    var objSocio = listaSocio[0];
                    txbNombre.Text = objSocio.nombre;
                    txbApellidos.Text = objSocio.apellidos;
                    txbDomicilio.Text = objSocio.domicilio;
                    mtbTelefono.Text = objSocio.telefono;
                    txbEmail.Text = objSocio.email;
                    mtbCuenta.Text = objSocio.cuentaCorriente;

                    //dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
                    //dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el DNI");
                }


            }
        }
    }
}
