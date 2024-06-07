using Sistema_Asistencia.Data_Access.Conection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Asistencia.Data_Access.Class_Data.Cursos;

namespace Sistema_Asistencia.Views
{
    public partial class frm_Cursos : Form
    {
        public frm_Cursos()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
            {
                var lst = (from d in db.Cursos
                           where d.Habilitado == "SI"
                           select new Sistema_Asistencia.Data_Access.Class_Data.Cursos._Cursos
                           {
                               Curso = d.Curso,
                               id = d.ID_Curso
                           }).AsQueryable();
                dgvCursos.DataSource = lst.ToList();
                dgvCursos.Columns[2].Visible = false;
            }
        }
        int contador;
        private void contar_cursos()
        {
            int x = dgvContarExistencia.Rows.Count;
            contador = x;
        }
        private bool existe(string nombre)
        {
            
            using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
            {
                var sql = from d in db.Cursos
                          where d.Curso == nombre
                          where d.Habilitado == "SI"
                          select d;
                dgvContarExistencia.DataSource = sql.ToList();
                contar_cursos();
                if (contador > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //return db.Cursos.Any(x => x.Curso == nombre );
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtcurso.Text == "")
            {
                MessageBox.Show("Escribe el nombre del curso por favor.", "Verifica:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (existe(txtcurso.Text) == true)
            {

                MessageBox.Show("Ya existe un curso con el nombre proporcionado, por favor ingresa uno nuevo.", "Verifica:", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtcurso.Clear();
                return;
            }
            if (lblestado.Text == "EDITAR")
            {
                using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                {
                    Cursos _c = new Cursos();
                    _c = db.Cursos.Find(Id);
                    _c.Curso = txtcurso.Text;
                    db.Entry(_c).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    refresh();
                }
            }
            else
            {
                using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                {
                    Cursos curs = new Cursos();
                    curs.Curso = txtcurso.Text;
                    curs.Habilitado = "SI";
                    db.Cursos.Add(curs);
                    int r = db.SaveChanges();

                }
                refresh();
            }
        }

        private void frm_Cursos_Load(object sender, EventArgs e)
        {
            refresh();
        }
        int Id;
        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dgvCursos.SelectedCells[2].Value.ToString());
                if (e.ColumnIndex == this.dgvCursos.Columns["eli"].Index)
                {
                    DialogResult Resul = MessageBox.Show("¿Estas seguro de eliminar el curso: " + dgvCursos.SelectedCells[3].Value.ToString() + "?", "Confirma:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Resul == DialogResult.Yes)
                    {
                        using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                        {
                            Cursos crn = db.Cursos.Find(Id);
                            crn.Habilitado = "NO";
                            db.Entry(crn).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            refresh();
                        }
                    }
                }
                else if(e.ColumnIndex == this.dgvCursos.Columns["edi"].Index)
                {
                    
                        using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                        {
                           Cursos crn = new Cursos();
                           crn =  db.Cursos.Find(Id);
                           txtcurso.Text = crn.Curso;
                        lblestado.Text = "EDITAR";
                        }
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
