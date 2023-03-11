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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMultas = new System.Windows.Forms.Button();
            this.btnLicencias = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.txtMobility = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInformes);
            this.groupBox1.Controls.Add(this.btnMultas);
            this.groupBox1.Controls.Add(this.btnLicencias);
            this.groupBox1.Controls.Add(this.btnVehiculos);
            this.groupBox1.Controls.Add(this.btnPersonas);
            this.groupBox1.Controls.Add(this.txtMobility);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Principal";
            // 
            // btnMultas
            // 
            this.btnMultas.Location = new System.Drawing.Point(391, 93);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Size = new System.Drawing.Size(75, 23);
            this.btnMultas.TabIndex = 4;
            this.btnMultas.Text = "Multas";
            this.btnMultas.UseVisualStyleBackColor = true;
            // 
            // btnLicencias
            // 
            this.btnLicencias.Location = new System.Drawing.Point(286, 93);
            this.btnLicencias.Name = "btnLicencias";
            this.btnLicencias.Size = new System.Drawing.Size(75, 23);
            this.btnLicencias.TabIndex = 3;
            this.btnLicencias.Text = "Licencias";
            this.btnLicencias.UseVisualStyleBackColor = true;
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Location = new System.Drawing.Point(180, 93);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(75, 23);
            this.btnVehiculos.TabIndex = 2;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnPersonas
            // 
            this.btnPersonas.Location = new System.Drawing.Point(52, 94);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(75, 23);
            this.btnPersonas.TabIndex = 1;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            // 
            // txtMobility
            // 
            this.txtMobility.AutoSize = true;
            this.txtMobility.Location = new System.Drawing.Point(257, 29);
            this.txtMobility.Name = "txtMobility";
            this.txtMobility.Size = new System.Drawing.Size(42, 13);
            this.txtMobility.TabIndex = 0;
            this.txtMobility.Text = "Mobility";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(32, 238);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(81, 23);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(52, 136);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(75, 23);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(626, 331);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMultas;
        private System.Windows.Forms.Button btnLicencias;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Label txtMobility;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnInformes;
    }
}