namespace Proyecto_Movilidad.Formularios
{
    partial class frmGestorMultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.dgvMultas = new System.Windows.Forms.DataGridView();
            this.Pagar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvSeleccionado = new System.Windows.Forms.DataGridView();
            this.IdMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(274, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestor De Multas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(142, 20);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(137, 20);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // dgvMultas
            // 
            this.dgvMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pagar});
            this.dgvMultas.Location = new System.Drawing.Point(27, 92);
            this.dgvMultas.Name = "dgvMultas";
            this.dgvMultas.Size = new System.Drawing.Size(701, 150);
            this.dgvMultas.TabIndex = 3;
            // 
            // Pagar
            // 
            this.Pagar.HeaderText = "Pagar";
            this.Pagar.Name = "Pagar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Proyecto_Movilidad.Properties.Resources.btnAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.Location = new System.Drawing.Point(343, 248);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(55, 44);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.dgvSeleccionado.Location = new System.Drawing.Point(23, 298);
            this.dgvSeleccionado.Name = "dgvSeleccionado";
            this.dgvSeleccionado.Size = new System.Drawing.Size(541, 150);
            this.dgvSeleccionado.TabIndex = 5;
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
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(423, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(381, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.label3.Location = new System.Drawing.Point(291, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(617, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Acuerdo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(587, 419);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(613, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPagar.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPagar.Location = new System.Drawing.Point(523, 486);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(88, 33);
            this.btnPagar.TabIndex = 13;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 53);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // frmGestorMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(741, 536);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvSeleccionado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvMultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGestorMultas";
            this.Text = "frmGestorMultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.DataGridView dgvMultas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento_Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPagar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.DataGridView dgvSeleccionado;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}