using Sistema_Asistencia.Data_Access.Conection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Asistencia.Data_Access.Complemento
{
    public class Contar_asistencia
    {
        int c;
        public  int Contar(string Nombre_Procedimiento, DataGridView Datalistado,string fecha,string curso)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Conexion.cn;
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(Nombre_Procedimiento, cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
                da.SelectCommand.Parameters.AddWithValue("@curso", curso);
                da.Fill(dt);
                Datalistado.DataSource = dt;
            }
            catch (Exception)
            {


            }
            //Contar Las FIlas
            try
            {
              c = Datalistado.Rows.Count;
            
            }
            catch (Exception)
            {

            }
            return c;
        }

    }
}
