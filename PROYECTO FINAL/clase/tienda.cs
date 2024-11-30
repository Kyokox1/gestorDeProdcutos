using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL.clase
{
    internal class tienda
    {
        public void insertarcliente(TextBox pid, TextBox panombre, TextBox pdescripcion,
       TextBox pcantidad, TextBox pprecio_v, TextBox pprecio_c)

        {
            clase.conexion objetoconexion = new clase.conexion();
            try
            {
                string query = "Insert into producto(id,nombre,descripcion,cantidad,precio_venta,precio_compra)" +
               "values(' " + pid.Text + "' ,'" +
                panombre.Text + "','" + pdescripcion.Text + "','" + pcantidad.Text + "','" +
               pprecio_v.Text + "','" + pprecio_c.Text + "')";
                SqlCommand micomando = new SqlCommand(query,
                objetoconexion.establecerconexion());
                SqlDataReader mireader;
                mireader = micomando.ExecuteReader();
                while (mireader.Read())
                {
                }
                MessageBox.Show(" Se guardo Correctamente");
                objetoconexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se logro guardar los registros-error" + ex.ToString());
            }
        }
        public void mostrarcliente(DataGridView g)
        {
            clase.conexion objetoconexion = new clase.conexion();
            try
            {
                g.DataSource = null;
                SqlDataAdapter adaptador = new SqlDataAdapter("select *from producto",
               objetoconexion.establecerconexion());
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                g.DataSource = dt;
                objetoconexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se logro mostrar los registros-error" + ex.ToString());
            }
        }
    }
}
