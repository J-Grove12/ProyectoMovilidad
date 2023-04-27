using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proyecto_Movilidad.Clases;

namespace Proyecto_Movilidad.Formularios
{
    public partial class frmMulta : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int contador, i, boton;
        public frmMulta()
        {
            InitializeComponent();
            cn = new cConexion(); ;
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblMulta", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        void llenar(DataTable dt, int i)
        {
            
            txtDocumento.Text = dt.Rows[i][1].ToString();
            txtValor.Text= dt.Rows[i][2].ToString();
            txtDireccion.Text= dt.Rows[i][3].ToString();
            if (dt.Rows[i][4].ToString().Equals("True"))
            {

                cmbEstado.SelectedIndex = 0;
            }
            else
            {

                cmbEstado.SelectedIndex = 1;
            }

            dtpFecha.Text = dt.Rows[i][5].ToString();
            txtDescripcion.Text = dt.Rows[i][6].ToString();

            //cantidad de registro en la tabla
            contador = dt.Rows.Count;
        }

        private void frmMulta_Load(object sender, EventArgs e)
        {
            llenar(dt, i);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {

            i = 0;
            llenar(dt, i);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            i--;
            if (i == -1)
            {
                i = 0;
                MessageBox.Show("llegaste a la primera persona");

            }
            llenar(dt, i);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            i++;
            if (i == contador)
            {
                MessageBox.Show("Legaste al ultimo cliente");
                i = contador - 1;
            }
            llenar(dt, i);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            i = contador - 1;
            llenar(dt, i);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void limpiar()
        {
           txtDescripcion.Clear();
           txtDireccion.Clear();
           txtDocumento.Clear();
           txtIdMulta.Clear();
           txtValor.Clear();
           cmbEstado.SelectedIndex = -1;
           dtpFecha.Text = "";

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            boton = 1;
            limpiar();
            txtDocumento.Enabled=true;
            txtDocumento.Focus();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            boton = 2;
            habilita();
            limpiar();
            txtDocumento.Focus();
            btnGuardar.Visible = true;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            boton = 3;
            habilita();
            limpiar();
            txtIdMulta.Enabled = true;
            txtIdMulta.Focus();
            btnGuardar.Visible = true;
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpiar();
            txtIdMulta.Enabled = true;
            txtIdMulta.Enabled = true;
            txtIdMulta.Focus();
        }

        private void txtIdMulta_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblMulta where IdMulta= '" + txtIdMulta.Text + "' ", cn.AbrirConexion());

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            i = 0;

            switch (boton)
            {
                case 3:
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(" NoExiste");
                        txtIdMulta.Clear();
                        txtIdMulta.Focus();
                    }
                    else
                    {
                        llenar(dt, i);
                    }
                    break;
                case 4:
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(" No Existe");
                        txtDocumento.Clear();
                        txtDocumento.Focus();
                    }
                    else
                    {
                        llenar(dt, i);
                        if (MessageBox.Show("desea Borrar La persona", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cm = new SqlCommand("delete from tblMulta where IdMulta = '" + txtIdMulta.Text + "' ", cn.AbrirConexion());
                            cm.ExecuteNonQuery();
                        }
                    }
                    break;
            }

        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblMulta where Documento_Persona= '" + txtDocumento.Text + "' ", cn.AbrirConexion());

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            i = 0;

            SqlCommand cmd1 = new SqlCommand("select * from tblPersona where Documento='" + Convert.ToInt16(txtDocumento.Text) + "'", cn.AbrirConexion());
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            txtNombre.Text = txtNombre.Text = dt1.Rows[0][1].ToString();

            switch (boton)
            {
                case 1:
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("NO EXISTE");
                        txtDocumento.Clear();
                        txtDocumento.Focus();
                    }
                    else
                    {

                        llenar(dt, i);
                    }
                    break;


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int act = 1;
            if (cmbEstado.SelectedIndex == 1)
            {
                act = 0;
            }
            if (boton == 2)

            {

                SqlCommand cmd = new SqlCommand("insert into tblMulta values('" + (txtDocumento.Text) + "','" + Convert.ToDouble(txtValor.Text) + "','" + txtDireccion.Text + "','" + act + "','" + dtpFecha.Text + "','" +  txtDescripcion.Text + "')", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Multa Guardada");
            }
            if (boton == 3)
            {
                SqlCommand cmd = new SqlCommand("update tblMulta set Documento_Persona='" + txtDocumento.Text + "' ,Valor= '" + Convert.ToDouble(txtValor.Text) + "',Direccion= '" + txtDireccion.Text + "',Estado= '" + act + "',FechaMulta='" + dtpFecha.Text + "',Descripcion='" + txtDescripcion + "' where IdMulta= '" + txtIdMulta.Text + "'", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Multa Modificada");
            }
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        void habilita()
        {
            txtDocumento.Enabled = true;
            txtValor.Enabled = true;
            txtDireccion.Enabled = true;
            cmbEstado.Enabled = true;
            dtpFecha.Enabled = true;
            txtDescripcion.Enabled = true;
        }
        void deshabilita()
        {
            txtDocumento.Enabled = false;
            txtValor.Enabled = false;
            txtDireccion.Enabled = false;
            cmbEstado.Enabled = false;
            dtpFecha.Enabled = false;
            txtDescripcion.Enabled = false;
        }   

    }
}
