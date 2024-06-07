using Sistema_Asistencia.Data_Access.Class_Data.Inicio;
using Sistema_Asistencia.Data_Access.Conection;
using Sistema_Asistencia.Views;
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


namespace Sistema_Asistencia
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void refrescar()
        {

            
            using(Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
            {
                var lst = (from d in db.Estudiantes
                          where d.Habilitado == "SI"
                          select new Inicio 
                          { 
                              No_Alumno = d.No__Estudiante,
                              Alumno = d.Nombre,
                              Padres = d.Padres_Tutor_a_,
                              Celular  = d. Celular,
                              Grado = d.Grado
                          }).AsQueryable();
                dgvEstudiantes.DataSource = lst.ToList();
                dgvEstudiantes.Columns[0].HeaderText = "No. Alumno";
                dgvEstudiantes.Columns[1].HeaderText = "Nombre Del Alumno";
                dgvEstudiantes.Columns[2].HeaderText = "Padres-Tutor(a)";
                dgvEstudiantes.Columns[3].HeaderText = "Celular Para Contactar";
                dgvEstudiantes.Columns[4].HeaderText = "Grado";

            }
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
           
           Verificar_conexion_Correcta_base();
            

            //Codigo para renombrar el texto de una columna
         //   dgvEstudiantes.Columns[0].HeaderText = "John Kerlin Silvestre";
        }
        string estado = "-";
        private void Verificar_conexion_Correcta_base()
        {
            Solicitar_Conexion_Base_Datos();
            Realizar_comprobacion_bd();
        }
        private void Solicitar_Conexion_Base_Datos()
        {
            try
            {
                using(Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                {
                    var Consult = from d in db.Cursos
                                  select d.Curso;
                    datalistadoConexion.DataSource = Consult.ToList();
                    estado = "ACTIVO";
                }
            }
            catch (Exception ex)
            {
                estado = "-";
            }
        }
        private void Realizar_comprobacion_bd()
        {
            if (estado == "ACTIVO")
            {
                refrescar();
            }
            else
            {
                Views.Instalacion_Base_Datos.Instalacion_del_servidor frm = new Views.Instalacion_Base_Datos.Instalacion_del_servidor();
                frm.ShowDialog();
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            frm_CrearEstudiante frm = new frm_CrearEstudiante();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {
            frm_TomarAsistencia frm = new frm_TomarAsistencia();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            frm_Cursos cr = new frm_Cursos();
            cr.ShowDialog();
        }

        private void btnConsultarAsistencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultarAsistenciaPorCurso frm = new frmConsultarAsistenciaPorCurso();
            frm.Show();

        }

        private void btnConsultarPorEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultarPorEstudiante Obj = new frmConsultarPorEstudiante();
            Obj.ShowDialog();
        }
    }
}
