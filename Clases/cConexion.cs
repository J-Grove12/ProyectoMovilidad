using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Proyecto_Movilidad.Clases
{
    internal class cConexion
    {
        //se define la ruta de la base de datos
        static private string cadenaconecion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\jonat\Documents\ProyectoPOO\Proyecto_Movilidad\dbMovilidad.mdf';Integrated Security=True;connect Timeout=30";
        //definir una variable para cargar la base de datos
        private SqlConnection Conexion = new SqlConnection(cadenaconecion);

        //C:\Users\jonat\Documents\ProyectoPOO\Proyecto_Movilidad\dbMovilidad.mdf

        //metodo para abrir la base de datos
        public SqlConnection AbrirConexion()
        {
            if(Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }
        //metodo para cerrar la base de datos
        public SqlConnection CerrarConexion() 
        {
            if(Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
