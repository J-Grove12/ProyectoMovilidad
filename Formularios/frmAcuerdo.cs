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
using Proyecto_Movilidad.Clases;
using System.Drawing.Printing;

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

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Document= new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Document.PrinterSettings = ps;
            Document.PrintPage += Imprimir;
            Document.Print();
        }
        private void Imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int total = 0;
            Font font = new Font("Arial", 12);
            Font titulo = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
            String DocumentoP = dgvSeleccionado.Rows[0].Cells[1].Value.ToString();
            int ancho = 350;
            int y = 170;
            Image imagen = Properties.Resources.Logo;
            e.Graphics.DrawImage(imagen, 0, 0, 300, 150);
            e.Graphics.DrawString("Recibo de pago Multas A Cuotas", titulo, Brushes.Black, new RectangleF(0, y, ancho, 20));
            e.Graphics.DrawString("Mobility", titulo, Brushes.Black, new RectangleF(0, y += 35, ancho, 20));
            e.Graphics.DrawString("Nit: 123456789", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Direccion: Cra 1 # 1-1", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Telefono: 123456789", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Ciudad: Bogota", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Documento:  " + DocumentoP, font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("Responsable:  " + txtNombre.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha:  " + (DateTime.Now.ToShortDateString()), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cuotas a pagar", titulo, Brushes.Black, new RectangleF(0, y += 35, ancho, 20));
            e.Graphics.DrawString("---------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));


            foreach (DataGridViewRow row in dgvCuotas.Rows)
            {
               
                
                bool isSelect = Convert.ToBoolean(row.Cells["PagarCuota"].Value);
                if (isSelect)
                {
                    e.Graphics.DrawString("Cuota Numero: " + Convert.ToString(row.Cells[0].Value.ToString()), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                    e.Graphics.DrawString("Valor: " + "$ " + Convert.ToString(row.Cells[1].Value.ToString()), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                    e.Graphics.DrawString("Fecha Limite : " + Convert.ToString(row.Cells[2].Value.ToString()), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                    e.Graphics.DrawString("--------------------------", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
                }
            
            }
            foreach (DataGridViewRow row in dgvCuotas.Rows)
            {
                bool isSelect = Convert.ToBoolean(row.Cells["PagarCuota"].Value);
                if (isSelect)
                {
                   total  += Convert.ToInt32(row.Cells["ValorCuota"].Value);
                }
            }
            e.Graphics.DrawString("Valor Total " + "$ " + total.ToString(), titulo, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

        }

    }
}
