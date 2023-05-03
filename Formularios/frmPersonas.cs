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
using System.Diagnostics;

namespace Proyecto_Movilidad.Formularios
{
    public partial class frmPersonas : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int contador, i, boton;
        public frmPersonas()
        {
            InitializeComponent();
            cn = new cConexion(); ;
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblPersona", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

        }
        void llenar(DataTable dt, int i)
        {
            txtDocumento.Text = dt.Rows[i][0].ToString();
            txtNombre.Text = dt.Rows[i][1].ToString();

            if(dt.Rows[i][2].ToString().Equals("True"))
            {
   
                cmbEstado.SelectedIndex = 0;
            }
            else
            {
 
                cmbEstado .SelectedIndex = 1;
            }
           
            dtpInscripcion.Text = dt.Rows[i][3].ToString();

            //cantidad de registro en la tabla
            contador = dt.Rows.Count;
        }

        void habilita()
        {
            txtDocumento.Enabled = true;
            cmbEstado.Enabled = true;
            txtNombre.Enabled = true;

            dtpInscripcion.Enabled = true;
        }

        private void frmPersonas_Load(object sender, EventArgs e)
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

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            boton = 1;
            limpiar();
            txtDocumento.Enabled = true;
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
            txtDocumento.Focus();
            btnGuardar.Visible = true;
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpiar();
            txtDocumento.Enabled = true;
            txtDocumento.Focus();
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblPersona where Documento= '" + txtDocumento.Text + "' ", cn.AbrirConexion());

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            i = 0;

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
                case 2:
                    if (dt.Rows.Count != 0)
                    {
                        MessageBox.Show("Existe");
                        llenar(dt, i);
                    }
                    break;
                case 3:
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(" NoExiste");
                        txtDocumento.Clear();
                        txtDocumento.Focus();
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
                        if (MessageBox.Show("desea Borarr La persona", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cm = new SqlCommand("delete from tblPersona where Documento = '" + txtDocumento.Text + "' ", cn.AbrirConexion());
                            cm.ExecuteNonQuery();
                        }
                    }
                    break;
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int act = 1;
            if(cmbEstado.SelectedIndex==1)
            {
                act = 0;
            }
            if (boton == 2)

            {
                SqlCommand cmd = new SqlCommand("insert into tblPersona values('" + Convert.ToInt32(txtDocumento.Text) + "', '" + txtNombre.Text + "','" + act + "','" + dtpInscripcion.Text + "')", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Persona Guardada");
            }
            if (boton == 3)
            {
                SqlCommand cmd = new SqlCommand("update tblPersona set Nombre='" + txtNombre.Text + "' ,Estado= '" + act + "',FechaInscrip= '" + dtpInscripcion.Text + "' where Documento= '" + txtDocumento.Text + "'", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Persona Modificada");
            }

        }

        void deshabilita()
        {
            txtDocumento.Enabled = false;
            cmbEstado.Enabled = false;
            txtNombre.Enabled = false;

            dtpInscripcion.Enabled = false;
        }
        void limpiar()
        {
            txtDocumento.Clear();
            
            txtNombre.Clear();

        }
    }
}
