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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //Recuperamos el objeto de la BD, filtrando por el campo categoria
                //categorias objCat = objBD.categorias.First(x => x.categoria.Equals(txbCategoria.Text));
                socios objSocios = objBD.socios.Find(txbDni.Text);
                if (objSocios != null)
                {
                    objSocios.nombre = txbNombre.Text;
                    objSocios.apellidos = txbApellidos.Text;
                    objSocios.domicilio = txbDomicilio.Text;
                    objSocios.telefono = mtbTelefono.Text;
                    objSocios.email = txbEmail.Text;
                    objSocios.cuentaCorriente = mtbCuenta.Text;


                    objBD.SaveChanges();
                    MessageBox.Show("modificado correctamente");
                }
                else { MessageBox.Show("El DNI no se puede modificar o No se ha encontrado el  DNI"); }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {

                var qSocios = from c in objBD.socios
                              orderby c.apellidos, c.nombre ascending
                              select new { c.DNI, c.nombre, c.apellidos, c.telefono, c.email};
                var listaSocios = qSocios.ToList();
                if (listaSocios.Count > 0) 
                {
                    dataGridView1.DataSource = listaSocios;
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            {
                using (clubraquetaEntities objBD = new clubraquetaEntities())
                {
                    //Creamos el objeto categoria
                    socios objSocio = new socios();
                    objSocio.DNI = txbDni.Text;
                    objSocio.nombre= txbNombre.Text;
                    objSocio.apellidos = txbApellidos.Text;
                    objSocio.domicilio = txbDomicilio.Text;
                    objSocio.telefono = mtbTelefono.Text;
                    objSocio.email = txbEmail.Text;
                    objSocio.cuentaCorriente = mtbCuenta.Text;
                    //se añade el objeto a la tabla, para incluirlo como nuevo...
                    objBD.socios.Add(objSocio);

                    //se guardan los cambios
                    objBD.SaveChanges();
                    MessageBox.Show("Socio guardado correctamente");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //Recuperamos el objeto de la BD, filtrando por el campo Socios

                socios objSocio = objBD.socios.Find(txbDni.Text);
                var consulta = from resr in objBD.reservas
                               from soc in objBD.socios
                               where soc.DNI == resr.socio && soc.DNI == txbDni.Text
                               select new { resr.idReserva };
                var qSocios = consulta.ToList();
                if (objSocio == null)
                {
                    MessageBox.Show("No se ha encontrado al socio");
                }
                else { 
                    if (qSocios.Count > 0)
                    {
                        MessageBox.Show("Este socio tiene Reservas pendientes y no se puede borrar");
                    }
                    else
                    {
                        //se elemina el objeto de la tabla, para quitarlo como registro
                        objBD.socios.Remove(objSocio);
                        //se guardan los cambios
                        objBD.SaveChanges();
                        MessageBox.Show("Socio borrado correctamente");
                    }
                }
                
            }
        }
    }
}


