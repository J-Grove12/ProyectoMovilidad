using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Movilidad.Formularios
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseño();        }
        void PersonalizarDiseño()
        {
            pnlOrganizacion.Visible = false;
            pnlPersona.Visible = false;
        }
        void ocultarSubmenu()
        {
            if (pnlPersona.Visible == true)
                pnlPersona.Visible = false;
            if (pnlOrganizacion.Visible == true)
                pnlOrganizacion.Visible = false;
        }
        void mostrarSubmenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                ocultarSubmenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        //variable que guarda el formulario activo
        private Form FormularioActivo = null;
        //abrir formularios hijos
        private void abrirFormulariosHijos(Form formularioHijo)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnOrganizacion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlOrganizacion);
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlPersona);
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmVehiculos());
            ocultarSubmenu();
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmPersonas());
            ocultarSubmenu();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
