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
            cn=new cConexion(); ;
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblPersona",cn.AbrirConexion());
            da= new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

        }
        void llenar(DataTable dt,int i)
        {
            txtDocumento.Text= dt.Rows[i][0].ToString();
            txtNombre.Text = dt.Rows[i][1].ToString();
            txtEstado.Text = dt.Rows[i][2].ToString();
            dtpInscripcion.Text = dt.Rows[i][3].ToString(); 
           
            //cantidad de registro en la tabla
            contador = dt.Rows.Count;
        }

        void habilita()
        {
            txtDocumento.Enabled= true;
            txtEstado.Enabled= true;
            txtNombre.Enabled= true;
           
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
            if(i == -1)
            {
                i=0;
                MessageBox.Show("llegaste a la primera persona");
                
            }
            llenar(dt, i);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            i++;
            if(i == contador)
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

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        void deshabilita()
        {
            txtDocumento.Enabled = false;
            txtEstado.Enabled =false;
            txtNombre.Enabled = false;
          
            dtpInscripcion.Enabled = false;
        }
        void limpiar()
        {
            txtDocumento.Clear();
            txtEstado.Clear();
            txtNombre.Clear();
          
        }
    }
}
