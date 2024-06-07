using Sistema_Asistencia.Data_Access.Conection;
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

namespace Sistema_Asistencia.Views._Reports
{
    public partial class ESTUDIANTES_SIN_ASISTIR : Form
    {
        public string Fecha { get; set; }
        public string Curso { get; set; }
        public ESTUDIANTES_SIN_ASISTIR()
        {
            InitializeComponent();
        }
        Reports_Document.Consulta_Asistencia_Estudiante.RptConsulta_estudiante rpt = new Reports_Document.Consulta_Asistencia_Estudiante.RptConsulta_estudiante();
        private void ESTUDIANTES_SIN_ASISTIR_Load(object sender, EventArgs e)
        {
     
            RefreshReport();
        }
        int Cantidad;
        private void Llenar_y_contar_Cantidad_sin_asistir()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Conexion.cn;
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("contar_estudiantes_sin_asistir", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", Fecha);
                da.SelectCommand.Parameters.AddWithValue("@curso", Curso);
                da.Fill(dt);
                dgvCantidad.DataSource = dt;
            }
            catch (Exception)
            {

                
            }
            //Contar Las FIlas
            try
            {
                int c = dgvCantidad.Rows.Count;
                Cantidad = c;
            }
            catch (Exception)
            {

            }
        }
        private void RefreshReport()
        {
            try
            {
                Llenar_y_contar_Cantidad_sin_asistir();
                DataTable dt = new DataTable();
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Conexion.cn;
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("Reporte_Estudiante_Sin_Asistir", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", Fecha);
                da.SelectCommand.Parameters.AddWithValue("@curso", Curso);
                da.SelectCommand.Parameters.AddWithValue("@cantidad", Cantidad);
                da.Fill(dt);
                rpt = new Reports_Document.Consulta_Asistencia_Estudiante.RptConsulta_estudiante();
                rpt.DataSource = dt;
                rpt.table1.DataSource = dt;
                reportViewer1.Report = rpt;
                reportViewer1.RefreshReport();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
