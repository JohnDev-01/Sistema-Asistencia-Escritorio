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

namespace Sistema_Asistencia.Views
{
    public partial class frmConsultarPorEstudiante : Form
    {
        public frmConsultarPorEstudiante()
        {
            InitializeComponent();
        }
        public static DataTable LoadDataTable()
        {
            var conexion = "server= localhost; database=Sistema_Asistencia_Profesor; Integrated Security = true";
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion;
            con.Open();

            da = new SqlDataAdapter("SELECT TOP 10 Nombre_Estudiante FROM Asistencia", con);

            da.Fill(dt);


            return dt;


            
        }
        public static AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = LoadDataTable();

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["Nombre_Estudiante"]));
            }

            return stringCol;
        }
        private void frmConsultarPorEstudiante_Load(object sender, EventArgs e)
        {
            txtestudiante.AutoCompleteCustomSource = LoadAutoComplete();
            txtestudiante.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtestudiante.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtestudiante_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtestudiante.Text == "")
            {
                MessageBox.Show("No hay ningun estudiante seleccionado.", "Consulta:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                string name = txtestudiante.Text;
                using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                {
                    var select = from d in db.Asistencia
                                 where d.Nombre_Estudiante == name
                                 select d;
                    dgvConsultarAsistencia.DataSource = select.ToList();

                }
                int contador = dgvConsultarAsistencia.Rows.Count;
                if (contador == 0)
                {
                    MessageBox.Show("No se a encontrado ningún registro.", "Verifica:", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnBuscar_Students_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiante_Para_Consultar frm = new frmBuscarEstudiante_Para_Consultar();
            frm.ShowDialog();

        }
    }
}
