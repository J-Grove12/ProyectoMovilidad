namespace Proyecto_Movilidad.Formularios
{
    partial class frmMenuPrincipal
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
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnMultas = new System.Windows.Forms.Button();
            this.btnLicencias = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPersona = new System.Windows.Forms.Panel();
            this.btnCrud = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.pnlOrganizacion = new System.Windows.Forms.Panel();
            this.btnOrganizacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlPersona.SuspendLayout();
            this.pnlOrganizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInformes
            // 
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformes.Location = new System.Drawing.Point(0, 0);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(205, 23);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // btnMultas
            // 
            this.btnMultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMultas.Location = new System.Drawing.Point(0, 23);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Size = new System.Drawing.Size(205, 27);
            this.btnMultas.TabIndex = 4;
            this.btnMultas.Text = "Multas";
            this.btnMultas.UseVisualStyleBackColor = true;
            // 
            // btnLicencias
            // 
            this.btnLicencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLicencias.Location = new System.Drawing.Point(0, 23);
            this.btnLicencias.Name = "btnLicencias";
            this.btnLicencias.Size = new System.Drawing.Size(205, 31);
            this.btnLicencias.TabIndex = 3;
            this.btnLicencias.Text = "Licencias";
            this.btnLicencias.UseVisualStyleBackColor = true;
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculos.Location = new System.Drawing.Point(0, 0);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(205, 23);
            this.btnVehiculos.TabIndex = 2;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(65, 347);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(81, 23);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlPersona);
            this.panel1.Controls.Add(this.btnPersona);
            this.panel1.Controls.Add(this.pnlOrganizacion);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnOrganizacion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 425);
            this.panel1.TabIndex = 5;
            // 
            // pnlPersona
            // 
            this.pnlPersona.Controls.Add(this.btnCrud);
            this.pnlPersona.Controls.Add(this.btnLicencias);
            this.pnlPersona.Controls.Add(this.btnVehiculos);
            this.pnlPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPersona.Location = new System.Drawing.Point(0, 251);
            this.pnlPersona.Name = "pnlPersona";
            this.pnlPersona.Size = new System.Drawing.Size(205, 90);
            this.pnlPersona.TabIndex = 8;
            // 
            // btnCrud
            // 
            this.btnCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrud.Location = new System.Drawing.Point(0, 54);
            this.btnCrud.Name = "btnCrud";
            this.btnCrud.Size = new System.Drawing.Size(205, 33);
            this.btnCrud.TabIndex = 4;
            this.btnCrud.Text = "Crud";
            this.btnCrud.UseVisualStyleBackColor = true;
            this.btnCrud.Click += new System.EventHandler(this.btnCrud_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersona.Location = new System.Drawing.Point(0, 222);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(205, 29);
            this.btnPersona.TabIndex = 9;
            this.btnPersona.Text = "persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // pnlOrganizacion
            // 
            this.pnlOrganizacion.Controls.Add(this.btnMultas);
            this.pnlOrganizacion.Controls.Add(this.btnInformes);
            this.pnlOrganizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrganizacion.Location = new System.Drawing.Point(0, 128);
            this.pnlOrganizacion.Name = "pnlOrganizacion";
            this.pnlOrganizacion.Size = new System.Drawing.Size(205, 94);
            this.pnlOrganizacion.TabIndex = 7;
            // 
            // btnOrganizacion
            // 
            this.btnOrganizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrganizacion.Location = new System.Drawing.Point(0, 105);
            this.btnOrganizacion.Name = "btnOrganizacion";
            this.btnOrganizacion.Size = new System.Drawing.Size(205, 23);
            this.btnOrganizacion.TabIndex = 6;
            this.btnOrganizacion.Text = "Organización";
            this.btnOrganizacion.UseVisualStyleBackColor = true;
            this.btnOrganizacion.Click += new System.EventHandler(this.btnOrganizacion_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 105);
            this.panel2.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(223, 12);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(816, 470);
            this.pnlContenedor.TabIndex = 6;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1047, 497);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.pnlPersona.ResumeLayout(false);
            this.pnlOrganizacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMultas;
        private System.Windows.Forms.Button btnLicencias;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOrganizacion;
        private System.Windows.Forms.Button btnOrganizacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPersona;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnCrud;
    }
}