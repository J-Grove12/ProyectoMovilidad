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
using System.Xml.Linq;
 using System.Drawing.Printing;





namespace Proyecto_Movilidad.Formularios
{
    public partial class frmGestorMultas : Form
    {
        cConexion cn;
        public frmGestorMultas()
        {
            InitializeComponent();
            cn = new cConexion();
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblPersona where Documento='" + Convert.ToInt16(txtDocumento.Text) + "'",cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtNombre.Text = dt.Rows[0][1].ToString();
                llenarMultas();
            }
            else
            {
                MessageBox.Show("El documento no existe");
                txtDocumento.Focus();
            }
            
        }
        void llenarMultas()
        {
            SqlCommand cmd = new SqlCommand("select * from tblMulta where Documento_Persona='" + Convert.ToInt16(txtDocumento.Text) + "' ", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMultas.DataSource = dt;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int Total = 0;
            foreach(DataGridViewRow row in dgvMultas.Rows)
            {
                bool isSelect = Convert.ToBoolean(row.Cells["Pagar"].Value);
                if(isSelect)
                {
                    int n = dgvSeleccionado.Rows.Add();
                    dgvSeleccionado.Rows[n].Cells[0].Value = row.Cells[1].Value.ToString();
                    dgvSeleccionado.Rows[n].Cells[1].Value = row.Cells[2].Value.ToString();
                    dgvSeleccionado.Rows[n].Cells[2].Value = row.Cells[3].Value.ToString();
                    dgvSeleccionado.Rows[n].Cells[3].Value = row.Cells[6].Value.ToString();
                    dgvSeleccionado.Rows[n].Cells[4].Value = row.Cells[7].Value.ToString();
                }
            }
            foreach (DataGridViewRow row in dgvSeleccionado.Rows)

            {
                Total += Convert.ToInt32(row.Cells["Valor"].Value);

            }
            txtTotal.Text = Total.ToString();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnPagar_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
            for (int Indice = 0; Indice < dgvSeleccionado.Rows.Count; Indice++)
            {
                if (dgvSeleccionado.Rows[Indice].Cells[0].Value != null)
                {
                        SqlCommand cmd = new SqlCommand("UPDATE tblPersona SET Estado = @Estado WHERE Documento = @Documento_Persona", cn.AbrirConexion());
                        cmd.Parameters.AddWithValue("@Estado", 0);
                        cmd.Parameters.AddWithValue("@Documento_Persona", dgvSeleccionado.Rows[Indice].Cells[1].Value);
                        cmd.ExecuteNonQuery();
                }
            }
        }

        private void Imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font= new Font("Arial", 12);
            Font titulo = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
            int ancho = 350;
            int y= 170;
            Image imagen= Properties.Resources.Logo;
            e.Graphics.DrawImage(imagen, 0, 0, 300, 150);
            e.Graphics.DrawString("Recibo de pago Multas Contado", titulo, Brushes.Black, new RectangleF(0, y, ancho, 20));
            e.Graphics.DrawString("Mobility", titulo, Brushes.Black, new RectangleF(0, y += 35, ancho, 20));
            e.Graphics.DrawString("Nit: 123456789", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Direccion: Cra 1 # 1-1", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Telefono: 123456789", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Ciudad: Bogota", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Documento:  "+txtDocumento.Text, font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("Responsable:  "+txtNombre.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha:  "+(DateTime.Now.ToShortDateString()), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Multas a pagar" , titulo, Brushes.Black, new RectangleF(0, y += 35, ancho, 20));
            e.Graphics.DrawString("---------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));


            foreach (DataGridViewRow row in dgvSeleccionado.Rows)
            {

                e.Graphics.DrawString("ID MULTA: "+Convert.ToString(row.Cells[0].Value.ToString()), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                e.Graphics.DrawString("Valor: "+"$ " + Convert.ToString(row.Cells[2].Value.ToString()), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                e.Graphics.DrawString("Fecha: " + Convert.ToString(row.Cells[3].Value.ToString()), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                e.Graphics.DrawString("Descripcion: " + Convert.ToString(row.Cells[4].Value.ToString()), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                e.Graphics.DrawString("--------------------------", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            }   
            e.Graphics.DrawString("Valor Total " + "$ " + txtTotal.Text, titulo, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

        }

        private void button1_Click(object sender, EventArgs e)
        {
        frmAcuerdo frm = new frmAcuerdo();
         foreach(DataGridViewRow fila in dgvSeleccionado.Rows)
            {
                Multas multas= new Multas();
                multas.IdMulta = fila.Cells[0].Value.ToString();
                multas.Documento_Persona = txtDocumento.Text;
                multas.Valor = fila.Cells[2].Value.ToString();
                multas.Fecha = fila.Cells[3].Value.ToString();
                multas.Descripcion = fila.Cells[4].Value.ToString();
                frm.multas.Add(multas);
            }
            frm.ShowDialog();

        }
    }
}
