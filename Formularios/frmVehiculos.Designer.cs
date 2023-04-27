namespace Proyecto_Movilidad.Formularios
{
    partial class frmVehiculos
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
            this.Vehiculo = new System.Windows.Forms.GroupBox();
            this.txtDueno = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblDueno = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCilindraje = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblAutoridad = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCilindraje = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAutoridad = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtNumeroMatricula = new System.Windows.Forms.TextBox();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbClaseVehiculo = new System.Windows.Forms.ComboBox();
            this.dtpMatricula = new System.Windows.Forms.DateTimePicker();
            this.Vehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vehiculo
            // 
            this.Vehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(209)))));
            this.Vehiculo.Controls.Add(this.dtpMatricula);
            this.Vehiculo.Controls.Add(this.cmbClaseVehiculo);
            this.Vehiculo.Controls.Add(this.cmbEstado);
            this.Vehiculo.Controls.Add(this.txtDueno);
            this.Vehiculo.Controls.Add(this.txtMarca);
            this.Vehiculo.Controls.Add(this.lblDueno);
            this.Vehiculo.Controls.Add(this.lblMarca);
            this.Vehiculo.Controls.Add(this.lblColor);
            this.Vehiculo.Controls.Add(this.lblCilindraje);
            this.Vehiculo.Controls.Add(this.lblModelo);
            this.Vehiculo.Controls.Add(this.lblFecha);
            this.Vehiculo.Controls.Add(this.lblAutoridad);
            this.Vehiculo.Controls.Add(this.lblClase);
            this.Vehiculo.Controls.Add(this.lblEstado);
            this.Vehiculo.Controls.Add(this.lblPlaca);
            this.Vehiculo.Controls.Add(this.lblNumero);
            this.Vehiculo.Controls.Add(this.txtColor);
            this.Vehiculo.Controls.Add(this.txtCilindraje);
            this.Vehiculo.Controls.Add(this.txtModelo);
            this.Vehiculo.Controls.Add(this.txtAutoridad);
            this.Vehiculo.Controls.Add(this.txtPlaca);
            this.Vehiculo.Controls.Add(this.txtNumeroMatricula);
            this.Vehiculo.Location = new System.Drawing.Point(63, 33);
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.Size = new System.Drawing.Size(387, 377);
            this.Vehiculo.TabIndex = 0;
            this.Vehiculo.TabStop = false;
            this.Vehiculo.Text = "groupBox1";
            // 
            // txtDueno
            // 
            this.txtDueno.Enabled = false;
            this.txtDueno.Location = new System.Drawing.Point(119, 336);
            this.txtDueno.Name = "txtDueno";
            this.txtDueno.Size = new System.Drawing.Size(100, 20);
            this.txtDueno.TabIndex = 21;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(119, 310);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 20;
            // 
            // lblDueno
            // 
            this.lblDueno.AutoSize = true;
            this.lblDueno.Location = new System.Drawing.Point(71, 336);
            this.lblDueno.Name = "lblDueno";
            this.lblDueno.Size = new System.Drawing.Size(42, 13);
            this.lblDueno.TabIndex = 19;
            this.lblDueno.Text = "Dueño:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(73, 310);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 18;
            this.lblMarca.Text = "Marca:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(79, 274);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Color:";
            // 
            // lblCilindraje
            // 
            this.lblCilindraje.AutoSize = true;
            this.lblCilindraje.Location = new System.Drawing.Point(61, 248);
            this.lblCilindraje.Name = "lblCilindraje";
            this.lblCilindraje.Size = new System.Drawing.Size(52, 13);
            this.lblCilindraje.TabIndex = 16;
            this.lblCilindraje.Text = "Cilindraje:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(68, 222);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 15;
            this.lblModelo.Text = "Módelo:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 197);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha de matricula:";
            // 
            // lblAutoridad
            // 
            this.lblAutoridad.AutoSize = true;
            this.lblAutoridad.Location = new System.Drawing.Point(6, 170);
            this.lblAutoridad.Name = "lblAutoridad";
            this.lblAutoridad.Size = new System.Drawing.Size(107, 13);
            this.lblAutoridad.TabIndex = 13;
            this.lblAutoridad.Text = "Autoridad de tránsito:";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(19, 142);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(94, 13);
            this.lblClase.TabIndex = 12;
            this.lblClase.Text = "Clase de vehiculo:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(70, 116);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(76, 90);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(37, 13);
            this.lblPlaca.TabIndex = 10;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 53);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(107, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número de matricula:";
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(119, 274);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 8;
            // 
            // txtCilindraje
            // 
            this.txtCilindraje.Enabled = false;
            this.txtCilindraje.Location = new System.Drawing.Point(119, 248);
            this.txtCilindraje.Name = "txtCilindraje";
            this.txtCilindraje.Size = new System.Drawing.Size(100, 20);
            this.txtCilindraje.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(119, 222);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 6;
            // 
            // txtAutoridad
            // 
            this.txtAutoridad.Enabled = false;
            this.txtAutoridad.Location = new System.Drawing.Point(119, 170);
            this.txtAutoridad.Name = "txtAutoridad";
            this.txtAutoridad.Size = new System.Drawing.Size(100, 20);
            this.txtAutoridad.TabIndex = 4;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(119, 90);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.Leave += new System.EventHandler(this.txtPlaca_Leave);
            // 
            // txtNumeroMatricula
            // 
            this.txtNumeroMatricula.Enabled = false;
            this.txtNumeroMatricula.Location = new System.Drawing.Point(119, 53);
            this.txtNumeroMatricula.Name = "txtNumeroMatricula";
            this.txtNumeroMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroMatricula.TabIndex = 0;
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnRetiro.Location = new System.Drawing.Point(456, 144);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 27;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = false;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnModificacion.Location = new System.Drawing.Point(456, 113);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(75, 23);
            this.btnModificacion.TabIndex = 26;
            this.btnModificacion.Text = "Modificacion";
            this.btnModificacion.UseVisualStyleBackColor = false;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnIngreso.Location = new System.Drawing.Point(456, 81);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 25;
            this.btnIngreso.Text = "ingreso";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(456, 178);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(209)))));
            this.btnSalir.Location = new System.Drawing.Point(456, 207);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnConsulta.Location = new System.Drawing.Point(456, 47);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 22;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnUltimo.Location = new System.Drawing.Point(234, 416);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(49, 23);
            this.btnUltimo.TabIndex = 31;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSiguiente.Location = new System.Drawing.Point(182, 416);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(46, 23);
            this.btnSiguiente.TabIndex = 30;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnAnterior.Location = new System.Drawing.Point(126, 416);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 23);
            this.btnAnterior.TabIndex = 29;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnPrimero.Location = new System.Drawing.Point(71, 416);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(49, 23);
            this.btnPrimero.TabIndex = 28;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(119, 116);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 22;
            // 
            // cmbClaseVehiculo
            // 
            this.cmbClaseVehiculo.Enabled = false;
            this.cmbClaseVehiculo.FormattingEnabled = true;
            this.cmbClaseVehiculo.Items.AddRange(new object[] {
            "Moto ",
            "Carro",
            "Bus",
            "Tractomula"});
            this.cmbClaseVehiculo.Location = new System.Drawing.Point(119, 143);
            this.cmbClaseVehiculo.Name = "cmbClaseVehiculo";
            this.cmbClaseVehiculo.Size = new System.Drawing.Size(111, 21);
            this.cmbClaseVehiculo.TabIndex = 23;
            // 
            // dtpMatricula
            // 
            this.dtpMatricula.Enabled = false;
            this.dtpMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMatricula.Location = new System.Drawing.Point(119, 197);
            this.dtpMatricula.Name = "dtpMatricula";
            this.dtpMatricula.Size = new System.Drawing.Size(141, 20);
            this.dtpMatricula.TabIndex = 24;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(552, 468);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.Vehiculo);
            this.Name = "frmVehiculos";
            this.Text = "frmVehiculos";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            this.Vehiculo.ResumeLayout(false);
            this.Vehiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Vehiculo;
        private System.Windows.Forms.TextBox txtDueno;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblDueno;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCilindraje;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblAutoridad;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCilindraje;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAutoridad;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtNumeroMatricula;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.DateTimePicker dtpMatricula;
        private System.Windows.Forms.ComboBox cmbClaseVehiculo;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}