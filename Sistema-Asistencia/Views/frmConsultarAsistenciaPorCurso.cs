using Sistema_Asistencia.Data_Access.Class_Data.Consultar_Asistencia;
using Sistema_Asistencia.Data_Access.Conection;
using Sistema_Asistencia.Views._Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Asistencia.Views
{
    public partial class frmConsultarAsistenciaPorCurso : Form
    {
        public frmConsultarAsistenciaPorCurso()
        {
            InitializeComponent();
        }
        private void Cargar_Cursos()
        {
            using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
            {
                var lst = (from d in db.Cursos
                           where d.Habilitado == "SI"

                           select new Data_Access.Class_Data.Cursos._Cursos
                           {
                               Curso = d.Curso
                           }).AsQueryable();
                cbCurso.DataSource = lst.ToList();
                cbCurso.DisplayMember = "Curso";
            }
        }
        private void frmConsultarAsistenciaPorCurso_Load(object sender, EventArgs e)
        {
            Cargar_Cursos();
        }
        private void Consultar_Asistencia()
        {
            string fecha;
            string curso;
            string estado_asistencia;


            if (rb_Asistio.Checked == true)
            {

                try
                {
                    fecha = dtFecha.Value.ToString("dd/MM/yyyy");
                    curso = cbCurso.Text;
                    estado_asistencia = "SI";
                    using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                    {
                        var sql = (from R in db.Asistencia
                                   where R.Fecha_Asistencia == fecha
                                   where R.Curso == curso
                                   where R.Asistencia1 == estado_asistencia
                                   select new _Class
                                   {
                                       Nombre = R.Nombre_Estudiante,
                                       Fecha = R.Fecha_Asistencia
                                   }).AsQueryable();
                        dgvConsultarAsistencia.DataSource = sql.ToList();

                    }
                }
                catch (Exception ex)
                {


                }
            }
            else if (rb_NoAsistio.Checked == true)
            {
                try
                {
                    fecha = dtFecha.Value.ToString("dd/MM/yyyy");
                    curso = cbCurso.Text;
                    estado_asistencia = "NO";
                    using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                    {
                        var sql = (from R in db.Asistencia
                                   where R.Fecha_Asistencia == fecha
                                   where R.Curso == curso
                                   where R.Asistencia1 == estado_asistencia
                                   select new _Class
                                   {
                                       Nombre = R.Nombre_Estudiante,
                                       Fecha = R.Fecha_Asistencia
                                   }).AsQueryable();
                        dgvConsultarAsistencia.DataSource = sql.ToList();

                    }
                }
                catch (Exception ex)
                {


                }
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Consultar_Asistencia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultar_Asistencia();
        }

        private void rb_Asistio_CheckedChanged(object sender, EventArgs e)
        {

            Consultar_Asistencia();
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            Consultar_Asistencia();
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            Consultar_Asistencia();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string fecha = dtFecha.Value.ToString("dd/MM/yyyy");
            ESTUDIANTES_SIN_ASISTIR frm = new ESTUDIANTES_SIN_ASISTIR();
            frm.Curso = cbCurso.Text;
            frm.Fecha = fecha;
            frm.ShowDialog();
        }

        private void frmConsultarAsistenciaPorCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Application.Restart();
        }
    }
}
