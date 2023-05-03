using Proyecto_Movilidad.Clases;
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


namespace Proyecto_Movilidad.Formularios
{
    public partial class frmVehiculos : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int contador, i, boton;
        public frmVehiculos()
        {
            InitializeComponent();
            cn = new cConexion(); ;
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblVehiculo", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        void llenar(DataTable dt, int i)
        {
            txtNumeroMatricula.Text = dt.Rows[i][0].ToString();
            txtPlaca.Text = dt.Rows[i][1].ToString();
            if (dt.Rows[i][2].ToString().Equals("True"))
            {

                cmbEstado.SelectedIndex = 0;
            }
            else
            {

                cmbEstado.SelectedIndex = 1;
            }

           if(dt.Rows[i][3].ToString().Equals("Moto"))
            {
                cmbClaseVehiculo.SelectedIndex= 0;
            }
            if (dt.Rows[i][3].ToString().Equals("Carro"))
            {
                cmbClaseVehiculo.SelectedIndex = 1;
            }
            if (dt.Rows[i][3].ToString().Equals("Bus"))
            {
                cmbClaseVehiculo.SelectedIndex = 2;
            }
            if (dt.Rows[i][3].ToString().Equals("Tractomula"))
            {
                cmbClaseVehiculo.SelectedIndex = 3;
            }
            txtAutoridad.Text = dt.Rows[i][4].ToString();
            dtpMatricula.Text= dt.Rows[i][5].ToString();
            txtModelo.Text = dt.Rows[i][6].ToString();
            txtCilindraje.Text = dt.Rows[i][7].ToString();
            txtColor.Text= dt.Rows[i][8].ToString();
            txtMarca.Text= dt.Rows[i][9].ToString();
            txtDueno.Text= dt.Rows[i][10].ToString();

            //cantidad de registro en la tabla
            contador = dt.Rows.Count;
        }
        void habilita()
        {
            txtAutoridad.Enabled = true;
            txtCilindraje.Enabled = true;
            txtPlaca.Enabled = true;
            txtColor.Enabled = true;
            txtDueno.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtNumeroMatricula.Enabled = true;
            cmbClaseVehiculo.Enabled = true;
            cmbEstado.Enabled = true;
            dtpMatricula.Enabled = true;
          
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            llenar(dt, i);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            i--;
            if (i == -1)
            {
                i = 0;
                MessageBox.Show("llegaste a el Primer Vehiculo");

            }
            llenar(dt, i);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            i++;
            if (i == contador)
            {
                MessageBox.Show("Legaste al ultimo Vehiculo");
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

        void deshabilita()
        {
            txtAutoridad.Enabled = false;
            txtCilindraje.Enabled =false;
            txtPlaca.Enabled = false;
            txtColor.Enabled = false;
            txtDueno.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtNumeroMatricula.Enabled = false;
            cmbClaseVehiculo.Enabled = false;
            cmbEstado.Enabled = false;

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            boton = 1;
            limpiar();
            txtPlaca.Enabled = true;
            txtPlaca.Focus();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            boton = 2;
            habilita();
            limpiar();
            btnGuardar.Visible= true;
            txtPlaca.Focus();

        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            boton = 3;
            habilita();
            limpiar();
            btnGuardar.Visible = true;
            txtPlaca.Focus();

        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpiar();
            txtPlaca.Enabled = true;
            txtPlaca.Focus();
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblVehiculo where Placa= '" + txtPlaca.Text + "' ", cn.AbrirConexion());

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
                        txtPlaca.Clear();
                        txtPlaca.Focus();
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
                        txtPlaca.Clear();
                        txtPlaca.Focus();
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
                        txtPlaca.Clear();
                        txtPlaca.Focus();
                    }
                    else
                    {
                        llenar(dt, i);
                        if (MessageBox.Show("desea Borrar este vehiculo", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cm = new SqlCommand("delete from tblVehiculo where Placa = '" + txtPlaca.Text + "' ", cn.AbrirConexion());
                            cm.ExecuteNonQuery();
                        }
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
            if (boton==2)
            {

                SqlCommand cmd = new SqlCommand("insert into tblVehiculo values('" + Convert.ToInt32(txtNumeroMatricula.Text) + "', '" + txtPlaca.Text + "','" + act + "','" + cmbClaseVehiculo.Text + "','" + txtAutoridad.Text + "','" + dtpMatricula.Text + "','" + txtModelo.Text + "','" + txtCilindraje.Text + "','" + txtColor.Text + "','" + txtMarca.Text + "','" + Convert.ToInt32(txtDueno.Text) + "')", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehiculo Guardado");
            }
            if(boton==3)
            {
                SqlCommand cmd = new SqlCommand("update tblVehiculo set Estado='" + act + "',Clase_Vehiculo='" + cmbClaseVehiculo.Text + "',Autoridad_Transito='"  + txtAutoridad.Text + "',Fecha_Matricula='" + dtpMatricula.Text + "',Modelo='" + txtModelo.Text + "',Cilindraje='" + txtCilindraje.Text + "',Color='" + txtColor.Text + "',Marca='" + txtMarca.Text + "',Dueño='" + Convert.ToInt32(txtDueno.Text) + "'where Placa= '" + txtPlaca.Text + "'", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehiculo Modificado");
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            llenar(dt, i);
        }
        void limpiar()
        {
            txtPlaca.Clear();
            txtColor.Clear();
            txtDueno.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtNumeroMatricula.Clear();
            txtCilindraje.Clear();
            txtAutoridad.Clear();
            
            

        }
       
    }
}
