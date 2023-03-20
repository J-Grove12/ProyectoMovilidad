using Proyecto_Movilidad.Clases;
using Proyecto_Movilidad.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Movilidad
{
    public partial class frmIngreso : Form
    {
        cConexion cn; //variable de conexion
        SqlCommand cmd;
        SqlDataAdapter da; //para consultas
        DataTable dt;
        int contador = 0;
        public frmIngreso()
        {
            InitializeComponent();
            cn= new cConexion();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cmd= new SqlCommand("select * from tblUsuario where usuario= '" + txtUsuario.Text + "' and contrasena= '" + txtContrasena.Text + "' ",cn.AbrirConexion());
            da= new SqlDataAdapter(cmd);
            dt= new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count ==0)
            {
                contador++;
                MessageBox.Show("Usuario o contraseña incorrectos, llevas " + contador + " intentos");
                txtContrasena.Clear();
                txtUsuario.Clear();
                
                if(contador==3)
                {
                    MessageBox.Show("No puedes entrar");
                    this.Close();
                }

            }
            else
            {
                frmMenuPrincipal frm=new frmMenuPrincipal();
                frm.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
