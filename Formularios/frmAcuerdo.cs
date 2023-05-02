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
using System.Data.SqlClient;
using Proyecto_Movilidad.Clases;

namespace Proyecto_Movilidad.Formularios
{
    public partial class frmAcuerdo : Form
    {
        public List<Clases.Multas> multas = new List<Clases.Multas>();
        cConexion cn;
        public frmAcuerdo()
        {

            InitializeComponent();
            cn = new cConexion();

        }
      
        private void frmAcuerdo_Load(object sender, EventArgs e)
        {
           foreach(var Multa in multas)
            {
                dgvSeleccionado.Rows.Add(Multa.IdMulta, Multa.Documento_Persona, Multa.Valor, Multa.Fecha, Multa.Descripcion);
                
            }
            SqlCommand cmd = new SqlCommand("select * from tblPersona where Documento='" + Convert.ToInt16(dgvSeleccionado.Rows[0].Cells[1].Value.ToString()) + "'", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtNombre.Text = dt.Rows[0][1].ToString();
             
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCuotas_SelectedValueChanged(object sender, EventArgs e)
        {
            CalcularCuotas();
        }
        void CalcularCuotas()
        {
            int Total = 0;
            foreach (DataGridViewRow row in dgvSeleccionado.Rows)
            {
                Total += Convert.ToInt32(row.Cells[2].Value.ToString());
            }
            int Cuotas = Convert.ToInt16(cmbCuotas.SelectedItem.ToString());
            double interes = 0.035;
            double valorCuota = (Total * interes) + Total;

            

            //llenar dgvCuotas
            for (int i = 0; i < Cuotas; i++)
            {

                DateTime Fecha;
                Fecha = DateTime.Now;
                DateTime fechames = Fecha.AddMonths(i);
                string fechaFormateada = fechames.ToString("dd-MM-yyyy");

                dgvCuotas.Rows.Add(i+1, valorCuota,fechaFormateada);


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            for (int Indice = 0; Indice < dgvCuotas.Rows.Count; Indice++)
            {
                if (dgvCuotas.Rows[Indice].Cells[0].Value != null)
                { 
                    SqlCommand cmd = new SqlCommand("insert into tblCuotas values('" + dgvCuotas.Rows[Indice].Cells[0].Value.ToString() + "' , '" + dgvCuotas.Rows[Indice].Cells[2].Value.ToString() + "' , '" + dgvCuotas.Rows[Indice].Cells[1].Value.ToString() + "')", cn.AbrirConexion());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Acuerdo guardado");
                    cn.CerrarConexion();
            }
        }
        }
    }
}
