namespace Proyecto_Movilidad.Formularios
{
    partial class frmAcuerdo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCuotas = new System.Windows.Forms.DataGridView();
            this.NCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgvSeleccionado = new System.Windows.Forms.DataGridView();
            this.IdMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Cuotas";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(243, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(101, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Responsable De Acuerdo";
            // 
            // dgvCuotas
            // 
            this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NCuota,
            this.ValorCuota,
            this.Fecha});
            this.dgvCuotas.Location = new System.Drawing.Point(27, 263);
            this.dgvCuotas.Name = "dgvCuotas";
            this.dgvCuotas.Size = new System.Drawing.Size(424, 150);
            this.dgvCuotas.TabIndex = 7;
            // 
            // NCuota
            // 
            this.NCuota.HeaderText = "N° Cuota";
            this.NCuota.Name = "NCuota";
            // 
            // ValorCuota
            // 
            this.ValorCuota.HeaderText = "Valor de la cuota";
            this.ValorCuota.Name = "ValorCuota";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de Expiracion de Pago";
            this.Fecha.Name = "Fecha";
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbCuotas.Location = new System.Drawing.Point(86, 206);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(77, 21);
            this.cmbCuotas.TabIndex = 8;
            this.cmbCuotas.SelectedValueChanged += new System.EventHandler(this.cmbCuotas_SelectedValueChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnPagar.Location = new System.Drawing.Point(364, 420);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // dgvSeleccionado
            // 
            this.dgvSeleccionado.AllowUserToAddRows = false;
            this.dgvSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMulta,
            this.Documento_Persona,
            this.Valor,
            this.Fecha_Multa,
            this.Descripcion});
            this.dgvSeleccionado.Location = new System.Drawing.Point(27, 58);
            this.dgvSeleccionado.Name = "dgvSeleccionado";
            this.dgvSeleccionado.Size = new System.Drawing.Size(443, 126);
            this.dgvSeleccionado.TabIndex = 10;
            // 
            // IdMulta
            // 
            this.IdMulta.HeaderText = "Id Multa";
            this.IdMulta.Name = "IdMulta";
            // 
            // Documento_Persona
            // 
            this.Documento_Persona.HeaderText = "Documento Persona";
            this.Documento_Persona.Name = "Documento_Persona";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Fecha_Multa
            // 
            this.Fecha_Multa.HeaderText = "Fecha";
            this.Fecha_Multa.Name = "Fecha_Multa";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSalir.Location = new System.Drawing.Point(283, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 49);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // frmAcuerdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(505, 485);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvSeleccionado);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.cmbCuotas);
            this.Controls.Add(this.dgvCuotas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAcuerdo";
            this.Text = "frmAcuerdo";
            this.Load += new System.EventHandler(this.frmAcuerdo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCuotas;
        private System.Windows.Forms.ComboBox cmbCuotas;
        private System.Windows.Forms.Button btnPagar;
        public System.Windows.Forms.DataGridView dgvSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento_Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}