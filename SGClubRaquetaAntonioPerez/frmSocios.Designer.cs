
namespace SGClubRaquetaAntonioPerez
{
    partial class frmSocios
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mtbCuenta = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txbDomicilio = new System.Windows.Forms.TextBox();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.labCuenta = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labTelefono = new System.Windows.Forms.Label();
            this.labDomicilio = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labDni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(472, 368);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 23);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(328, 368);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 23);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(456, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 23);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mtbCuenta
            // 
            this.mtbCuenta.Location = new System.Drawing.Point(328, 304);
            this.mtbCuenta.Mask = "ES0000000000000000000000";
            this.mtbCuenta.Name = "mtbCuenta";
            this.mtbCuenta.Size = new System.Drawing.Size(256, 22);
            this.mtbCuenta.TabIndex = 33;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(328, 264);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(256, 22);
            this.txbEmail.TabIndex = 32;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(328, 216);
            this.mtbTelefono.Mask = "600000000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(256, 22);
            this.mtbTelefono.TabIndex = 31;
            // 
            // txbDomicilio
            // 
            this.txbDomicilio.Location = new System.Drawing.Point(328, 176);
            this.txbDomicilio.Name = "txbDomicilio";
            this.txbDomicilio.Size = new System.Drawing.Size(256, 22);
            this.txbDomicilio.TabIndex = 30;
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(328, 136);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(256, 22);
            this.txbApellidos.TabIndex = 29;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(328, 96);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(256, 22);
            this.txbNombre.TabIndex = 28;
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(168, 40);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(256, 22);
            this.txbDni.TabIndex = 27;
            // 
            // labCuenta
            // 
            this.labCuenta.AutoSize = true;
            this.labCuenta.Location = new System.Drawing.Point(192, 304);
            this.labCuenta.Name = "labCuenta";
            this.labCuenta.Size = new System.Drawing.Size(115, 17);
            this.labCuenta.TabIndex = 26;
            this.labCuenta.Text = "Cuenta Corriente";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(265, 264);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(42, 17);
            this.labEmail.TabIndex = 25;
            this.labEmail.Text = "Email";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(243, 216);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(64, 17);
            this.labTelefono.TabIndex = 24;
            this.labTelefono.Text = "Teléfono";
            // 
            // labDomicilio
            // 
            this.labDomicilio.AutoSize = true;
            this.labDomicilio.Location = new System.Drawing.Point(248, 176);
            this.labDomicilio.Name = "labDomicilio";
            this.labDomicilio.Size = new System.Drawing.Size(64, 17);
            this.labDomicilio.TabIndex = 23;
            this.labDomicilio.Text = "Domicilio";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Location = new System.Drawing.Point(247, 136);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(65, 17);
            this.labApellido.TabIndex = 22;
            this.labApellido.Text = "Apellidos";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(254, 95);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(58, 17);
            this.labNombre.TabIndex = 21;
            this.labNombre.Text = "Nombre";
            // 
            // labDni
            // 
            this.labDni.AutoSize = true;
            this.labDni.Location = new System.Drawing.Point(121, 40);
            this.labDni.Name = "labDni";
            this.labDni.Size = new System.Drawing.Size(31, 17);
            this.labDni.TabIndex = 20;
            this.labDni.Text = "DNI";
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.mtbCuenta);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.txbDomicilio);
            this.Controls.Add(this.txbApellidos);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.labCuenta);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labTelefono);
            this.Controls.Add(this.labDomicilio);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.labDni);
            this.Name = "frmSocios";
            this.Text = "frmSocios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mtbCuenta;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.TextBox txbDomicilio;
        private System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.Label labCuenta;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.Label labDomicilio;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labDni;
    }
}