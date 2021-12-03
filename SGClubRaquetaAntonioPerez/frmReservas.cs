using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaAntonioPerez
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
            cargarSocio();
            listaPistas();
        }
       
        clubraquetaDataSetTableAdapters.sociosTableAdapter TablaSocio = new clubraquetaDataSetTableAdapters.sociosTableAdapter();
        clubraquetaDataSet dataSet = new clubraquetaDataSet();
        clubraquetaDataSetTableAdapters.pistasTableAdapter TablaPista = new clubraquetaDataSetTableAdapters.pistasTableAdapter();
        clubraquetaDataSet dataSetPistas = new clubraquetaDataSet();
        clubraquetaDataSetTableAdapters.reservasTableAdapter TablaReserva = new clubraquetaDataSetTableAdapters.reservasTableAdapter();
        clubraquetaDataSet dataSetReservas = new clubraquetaDataSet();
        List<string> pkSocio = new List<string>();
        
        private void cargarSocio()
        {
            TablaSocio.FillByApellidosNombre(dataSet.socios);
            for (int i = 0; i < dataSet.socios.Count; i++)
            {
                cmbSocios.Items.Add(dataSet.socios[i].apellidos + "," + dataSet.socios[i].nombre);
                pkSocio.Add(dataSet.socios[i].DNI);
            }
        }

        private void listaPistas()
        {
            TablaPista.FillBypistasNombre(dataSetPistas.pistas);
            for (int i = 0; i < dataSetPistas.pistas.Count; i++)
            {
                cbPista.Items.Add(dataSetPistas.pistas[i].nombre);
            }
        }
        private void cmbSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seleccionando cada elemento en su caja
            TablaSocio.FillByPrimaryKey(dataSet.socios, pkSocio[cmbSocios.SelectedIndex]);
            dgvAux.DataSource = dataSet.socios;
            labDniResultado.Text = dgvAux.Rows[0].Cells[0].Value.ToString();
            txtNombre.Text = dgvAux.Rows[0].Cells[1].Value.ToString();
            txtApellidos.Text = dgvAux.Rows[0].Cells[2].Value.ToString();
            txtDireccion.Text = dgvAux.Rows[0].Cells[3].Value.ToString();
            mtbTelefono.Text = dgvAux.Rows[0].Cells[4].Value.ToString();
            txtEmail.Text = dgvAux.Rows[0].Cells[5].Value.ToString();
            mtbCuenta.Text = dgvAux.Rows[0].Cells[6].Value.ToString();

            TablaReserva.FillByReservas(dataSetReservas.reservas, labDniResultado.Text);
            dgvLista.DataSource = dataSetReservas.reservas;
            dgvLista.Columns[0].Visible = false;
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {

            Boolean flagEstado = false;
            //si estan seleccionadas
            if (!labDniResultado.Text.Equals("") && !cbPista.SelectedIndex.Equals(-1))
            {
                String fecha = dateFecha.Value.ToShortDateString();
                String str_hora = "";
                if (int.Parse(numMinutos.Value.ToString()) == 0)
                {
                    str_hora = "" + numHora.Value + ":" + numMinutos.Value + "0:00";
                }
                else
                {
                    str_hora = "" + numHora.Value + ":" + numMinutos.Value + ":00";
                }
                dgvAux.DataSource = dataSetPistas.pistas;
                TablaReserva.FillByEstado(dataSetReservas.reservas, int.Parse(dgvAux.Rows[0].Cells[0].Value.ToString()), labDniResultado.Text, "No");
                //si hay reservas
                if (dataSetReservas.reservas.Rows.Count > 0)
                {
                    DialogResult rs = MessageBox.Show("El socio tiene abonos pendientes", "Advertencia", MessageBoxButtons.OK);
                    flagEstado = true;
                }
                if (!flagEstado)
                {
                    TablaReserva.FillByCombrobarPistaFechaHora(dataSetReservas.reservas, int.Parse(dgvAux.Rows[0].Cells[0].Value.ToString()), str_hora, fecha);
                    if (dataSetReservas.reservas.Rows.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("La pista está reservada", "Advertencia", MessageBoxButtons.OK);
                    }
                    else
                    {
                        TablaReserva.FillByPistaFecha(dataSetReservas.reservas, int.Parse(dgvAux.Rows[0].Cells[0].Value.ToString()), fecha);
                        if (dataSetReservas.reservas.Rows.Count > 0)
                        {
                            TimeSpan r = TimeSpan.Parse(dgvLista.Rows[0].Cells[2].Value.ToString());
                            TimeSpan s = TimeSpan.Parse(str_hora);
                            TimeSpan time2 = new TimeSpan(1, 30, 0);
                            TimeSpan d = r + time2;
                            TimeSpan f = r - time2;
                            
                            if (s < d || s > f)
                            {
                                DialogResult rt = MessageBox.Show("La pista aún está ocupada en este momento", "Advertencia", MessageBoxButtons.OK);
                            }
                            else
                            {
                                DialogResult rs = MessageBox.Show("Se va a realizar la reserva", "Advertencia", MessageBoxButtons.YesNo);
                                if (rs == DialogResult.Yes)
                                {
                                    TablaReserva.InsertQueryAddNuevo(fecha, str_hora, int.Parse(dgvAux.Rows[0].Cells[0].Value.ToString()), labDniResultado.Text, "No", 12);
                                    DialogResult re = MessageBox.Show("Reserva Realizada ", "Advertencia", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            DialogResult rs = MessageBox.Show("Se va a realizar la reserva", "Advertencia", MessageBoxButtons.YesNo);
                            if (rs == DialogResult.Yes)
                            {
                                TablaReserva.InsertQueryAddNuevo(fecha, str_hora, int.Parse(dgvAux.Rows[0].Cells[0].Value.ToString()), labDniResultado.Text, "No", 12);
                                DialogResult re = MessageBox.Show("Reserva Realizada ", "Advertencia", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                TablaReserva.FillByResultado(dataSetReservas.reservas, labDniResultado.Text);
                dgvLista.DataSource = dataSetReservas.reservas;
            }
            else
            
            {
                DialogResult rs = MessageBox.Show("Seleccione Socio y pista", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void cmbPista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!labDniResultado.Text.Equals(""))
            
            {
                //cabiar foto de pista
                TablaPista.FillByBuscarNombre(dataSetPistas.pistas, cbPista.SelectedItem.ToString());
                if (dataSetPistas.pistas.Rows.Count > 0)
                {
                    DataRow dr = dataSetPistas.pistas.Rows[0];
                    byte[] MyData = (byte[])dr["foto"];
                    MemoryStream stream = new MemoryStream(MyData);
                    picBoxPistas.Image = Image.FromStream(stream);
                }
                
                TablaReserva.FillByResultado(dataSetReservas.reservas, labDniResultado.Text);
                dgvLista.DataSource = dataSetReservas.reservas;
                dgvLista.Columns[0].Visible = false;

            }
            else
            {
                DialogResult rs = MessageBox.Show("Selecciona un Socio", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //si hay seleccionado
            if (dgvLista.SelectedRows.Count > 0)
            {
                //si el pago esta a NO
                if (dgvLista.SelectedRows[0].Cells[5].Value.Equals("No"))
                {

                    TablaReserva.UpdateQueryPagoId("Si", int.Parse(dgvLista.SelectedRows[0].Cells[0].Value.ToString()), int.Parse(dgvLista.SelectedRows[0].Cells[0].Value.ToString()));
                    DialogResult dr = MessageBox.Show("Reserva Pagada", "Advertencia", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Ya pagada", "Advertencia", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult rs = MessageBox.Show("Selecciona una fila", "Advertencia", MessageBoxButtons.OK);
            }
            
            TablaReserva.FillByResultado(dataSetReservas.reservas, labDniResultado.Text);
            dgvLista.DataSource = dataSetReservas.reservas;
            dgvLista.Columns[0].Visible = false;
        }

        private void numMinutos_ValueChanged(object sender, EventArgs e)
        {
            if (numMinutos.Value == 60)
            {
                numMinutos.Value = 0;
                numHora.Value = numHora.Value + 1;
            }
        }
    }
}
