
namespace SGClubRaquetaAntonioPerez
{
    partial class frmReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtbCuenta = new System.Windows.Forms.MaskedTextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labTelefono = new System.Windows.Forms.Label();
            this.labApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.labCuenta = new System.Windows.Forms.Label();
            this.labDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.picBoxPistas = new System.Windows.Forms.PictureBox();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.lblabel = new System.Windows.Forms.Label();
            this.numHora = new System.Windows.Forms.NumericUpDown();
            this.labHora = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.labFecha = new System.Windows.Forms.Label();
            this.cbPista = new System.Windows.Forms.ComboBox();
            this.labPista = new System.Windows.Forms.Label();
            this.dgvAux = new System.Windows.Forms.DataGridView();
            this.labDniResultado = new System.Windows.Forms.Label();
            this.labDni = new System.Windows.Forms.Label();
            this.cmbSocios = new System.Windows.Forms.ComboBox();
            this.labSocio = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(416, 536);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(135, 46);
            this.btnPagar.TabIndex = 23;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeColumns = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(24, 416);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(920, 102);
            this.dgvLista.TabIndex = 22;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(27, 63);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.mtbCuenta);
            this.splitContainer1.Panel1.Controls.Add(this.labEmail);
            this.splitContainer1.Panel1.Controls.Add(this.labNombre);
            this.splitContainer1.Panel1.Controls.Add(this.mtbTelefono);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.labTelefono);
            this.splitContainer1.Panel1.Controls.Add(this.labApellidos);
            this.splitContainer1.Panel1.Controls.Add(this.txtApellidos);
            this.splitContainer1.Panel1.Controls.Add(this.labCuenta);
            this.splitContainer1.Panel1.Controls.Add(this.labDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.txtDireccion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnReservar);
            this.splitContainer1.Panel2.Controls.Add(this.picBoxPistas);
            this.splitContainer1.Panel2.Controls.Add(this.numMinutos);
            this.splitContainer1.Panel2.Controls.Add(this.lblabel);
            this.splitContainer1.Panel2.Controls.Add(this.numHora);
            this.splitContainer1.Panel2.Controls.Add(this.labHora);
            this.splitContainer1.Panel2.Controls.Add(this.dateFecha);
            this.splitContainer1.Panel2.Controls.Add(this.labFecha);
            this.splitContainer1.Panel2.Controls.Add(this.cbPista);
            this.splitContainer1.Panel2.Controls.Add(this.labPista);
            this.splitContainer1.Size = new System.Drawing.Size(917, 345);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(576, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(304, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // mtbCuenta
            // 
            this.mtbCuenta.Location = new System.Drawing.Point(576, 69);
            this.mtbCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCuenta.Mask = "ES0000000000000000000000";
            this.mtbCuenta.Name = "mtbCuenta";
            this.mtbCuenta.ReadOnly = true;
            this.mtbCuenta.Size = new System.Drawing.Size(304, 22);
            this.mtbCuenta.TabIndex = 7;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(496, 121);
            this.labEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(46, 17);
            this.labEmail.TabIndex = 10;
            this.labEmail.Text = "Email:";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(32, 21);
            this.labNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(62, 17);
            this.labNombre.TabIndex = 0;
            this.labNombre.Text = "Nombre:";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(576, 25);
            this.mtbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTelefono.Mask = "600000000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.ReadOnly = true;
            this.mtbTelefono.Size = new System.Drawing.Size(184, 22);
            this.mtbTelefono.TabIndex = 9;
            this.mtbTelefono.ValidatingType = typeof(int);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 17);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(257, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(496, 25);
            this.labTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(68, 17);
            this.labTelefono.TabIndex = 8;
            this.labTelefono.Text = "Telefono:";
            // 
            // labApellidos
            // 
            this.labApellidos.AutoSize = true;
            this.labApellidos.Location = new System.Drawing.Point(25, 68);
            this.labApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(69, 17);
            this.labApellidos.TabIndex = 2;
            this.labApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(121, 64);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(257, 22);
            this.txtApellidos.TabIndex = 3;
            // 
            // labCuenta
            // 
            this.labCuenta.AutoSize = true;
            this.labCuenta.Location = new System.Drawing.Point(496, 69);
            this.labCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCuenta.Name = "labCuenta";
            this.labCuenta.Size = new System.Drawing.Size(39, 17);
            this.labCuenta.TabIndex = 6;
            this.labCuenta.Text = "CCC:";
            // 
            // labDireccion
            // 
            this.labDireccion.AutoSize = true;
            this.labDireccion.Location = new System.Drawing.Point(23, 107);
            this.labDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDireccion.Name = "labDireccion";
            this.labDireccion.Size = new System.Drawing.Size(71, 17);
            this.labDireccion.TabIndex = 4;
            this.labDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(121, 104);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(257, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(379, 89);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(135, 47);
            this.btnReservar.TabIndex = 9;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // picBoxPistas
            // 
            this.picBoxPistas.Location = new System.Drawing.Point(604, 21);
            this.picBoxPistas.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxPistas.Name = "picBoxPistas";
            this.picBoxPistas.Size = new System.Drawing.Size(287, 118);
            this.picBoxPistas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPistas.TabIndex = 8;
            this.picBoxPistas.TabStop = false;
            // 
            // numMinutos
            // 
            this.numMinutos.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMinutos.Location = new System.Drawing.Point(196, 102);
            this.numMinutos.Margin = new System.Windows.Forms.Padding(4);
            this.numMinutos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(52, 22);
            this.numMinutos.TabIndex = 7;
            this.numMinutos.ValueChanged += new System.EventHandler(this.numMinutos_ValueChanged);
            // 
            // lblabel
            // 
            this.lblabel.AutoSize = true;
            this.lblabel.Location = new System.Drawing.Point(175, 105);
            this.lblabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblabel.Name = "lblabel";
            this.lblabel.Size = new System.Drawing.Size(12, 17);
            this.lblabel.TabIndex = 6;
            this.lblabel.Text = ":";
            // 
            // numHora
            // 
            this.numHora.Location = new System.Drawing.Point(121, 102);
            this.numHora.Margin = new System.Windows.Forms.Padding(4);
            this.numHora.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numHora.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numHora.Name = "numHora";
            this.numHora.Size = new System.Drawing.Size(45, 22);
            this.numHora.TabIndex = 5;
            this.numHora.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // labHora
            // 
            this.labHora.AutoSize = true;
            this.labHora.Location = new System.Drawing.Point(36, 105);
            this.labHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labHora.Name = "labHora";
            this.labHora.Size = new System.Drawing.Size(79, 17);
            this.labHora.TabIndex = 4;
            this.labHora.Text = "Hora Inicio:";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(121, 59);
            this.dateFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(127, 22);
            this.dateFecha.TabIndex = 3;
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Location = new System.Drawing.Point(36, 66);
            this.labFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(51, 17);
            this.labFecha.TabIndex = 2;
            this.labFecha.Text = "Fecha:";
            // 
            // cbPista
            // 
            this.cbPista.FormattingEnabled = true;
            this.cbPista.Location = new System.Drawing.Point(121, 21);
            this.cbPista.Margin = new System.Windows.Forms.Padding(4);
            this.cbPista.Name = "cbPista";
            this.cbPista.Size = new System.Drawing.Size(257, 24);
            this.cbPista.TabIndex = 1;
            this.cbPista.SelectedIndexChanged += new System.EventHandler(this.cmbPista_SelectedIndexChanged);
            // 
            // labPista
            // 
            this.labPista.AutoSize = true;
            this.labPista.Location = new System.Drawing.Point(36, 25);
            this.labPista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPista.Name = "labPista";
            this.labPista.Size = new System.Drawing.Size(43, 17);
            this.labPista.TabIndex = 0;
            this.labPista.Text = "Pista:";
            // 
            // dgvAux
            // 
            this.dgvAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAux.Location = new System.Drawing.Point(423, 338);
            this.dgvAux.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAux.Name = "dgvAux";
            this.dgvAux.RowHeadersWidth = 51;
            this.dgvAux.Size = new System.Drawing.Size(13, 12);
            this.dgvAux.TabIndex = 20;
            // 
            // labDniResultado
            // 
            this.labDniResultado.AutoSize = true;
            this.labDniResultado.Location = new System.Drawing.Point(415, 24);
            this.labDniResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDniResultado.Name = "labDniResultado";
            this.labDniResultado.Size = new System.Drawing.Size(0, 17);
            this.labDniResultado.TabIndex = 19;
            // 
            // labDni
            // 
            this.labDni.AutoSize = true;
            this.labDni.Location = new System.Drawing.Point(328, 24);
            this.labDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDni.Name = "labDni";
            this.labDni.Size = new System.Drawing.Size(74, 17);
            this.labDni.TabIndex = 18;
            this.labDni.Text = "DNI Socio:";
            // 
            // cmbSocios
            // 
            this.cmbSocios.FormattingEnabled = true;
            this.cmbSocios.Location = new System.Drawing.Point(137, 21);
            this.cmbSocios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSocios.Name = "cmbSocios";
            this.cmbSocios.Size = new System.Drawing.Size(160, 24);
            this.cmbSocios.TabIndex = 17;
            this.cmbSocios.SelectedIndexChanged += new System.EventHandler(this.cmbSocios_SelectedIndexChanged);
            // 
            // labSocio
            // 
            this.labSocio.AutoSize = true;
            this.labSocio.Location = new System.Drawing.Point(31, 24);
            this.labSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSocio.Name = "labSocio";
            this.labSocio.Size = new System.Drawing.Size(97, 17);
            this.labSocio.TabIndex = 16;
            this.labSocio.Text = "Elige al Socio:";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 602);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dgvAux);
            this.Controls.Add(this.labDniResultado);
            this.Controls.Add(this.labDni);
            this.Controls.Add(this.cmbSocios);
            this.Controls.Add(this.labSocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtbCuenta;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label labCuenta;
        private System.Windows.Forms.Label labDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.PictureBox picBoxPistas;
        private System.Windows.Forms.NumericUpDown numMinutos;
        private System.Windows.Forms.Label lblabel;
        private System.Windows.Forms.NumericUpDown numHora;
        private System.Windows.Forms.Label labHora;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.ComboBox cbPista;
        private System.Windows.Forms.Label labPista;
        private System.Windows.Forms.DataGridView dgvAux;
        private System.Windows.Forms.Label labDniResultado;
        private System.Windows.Forms.Label labDni;
        private System.Windows.Forms.ComboBox cmbSocios;
        private System.Windows.Forms.Label labSocio;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}