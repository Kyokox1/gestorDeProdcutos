using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL.clase
{
    internal class conexion
    {
        SqlConnection conex = new SqlConnection();
        string cadenaconexion = "Data Source=DESKTOP-KM9280Q;initial catalog=TIENDA;integrated Security = true";
        public SqlConnection establecerconexion()
        {
            try
            {
                conex.ConnectionString = cadenaconexion;
                conex.Open();
                // MessageBox.Show("se conecto corectamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto corectamente" + ex.ToString());
            }
            return conex;

        }
        public void cerrarconexion()
        {
            conex.Close();
        }
    }
}
