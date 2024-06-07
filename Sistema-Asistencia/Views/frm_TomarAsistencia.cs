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
using Sistema_Asistencia.Data_Access.Class_Data.Inicio;
using Sistema_Asistencia.Data_Access.Class_Data.Tomar_Asistencia;

namespace Sistema_Asistencia.Views
{
    public partial class frm_TomarAsistencia : Form
    {
        public frm_TomarAsistencia()
        {
            InitializeComponent();
        }

        private void frm_TomarAsistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmInicio frm = new frmInicio();
            Dispose();
            frm.ShowDialog();
        }
        private void Cargar_Cursos()
        {
            using(Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
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
        private void Agregar_Columna()
        {
            DataGridViewCheckBoxColumn colu = new DataGridViewCheckBoxColumn();
            colu.HeaderText = "Asistío";
            colu.Name = "check";
            
            dgvTomarAsistencia.Columns.Add(colu);
            foreach (DataGridViewColumn column in dgvTomarAsistencia.Columns)
            {
                if (column.Name == "check")
                {
                    column.Width = 180;
                    
                }
                
            }
        }
        private void eliminar_Columna()
        {
            int contador = 0;
            foreach (DataGridViewColumn column in dgvTomarAsistencia.Columns)
            {
                if(column.Name == "check")
                {
                    contador++;
                }
                if(contador > 1)
                {
                    //int Indice = dgvTomarAsistencia.Columns["check"].Index;
                    dgvTomarAsistencia.Columns.RemoveAt(column.Index);
                }
            }

     
        }
        private void ListarEstudiantes()
        {
            using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
            {
                var sqlConsult = (from d in db.Estudiantes
                                  where d.Habilitado == "SI"
                                  where d.Grado == cbCurso.Text
                                  select new Listar_Asistencia
                                  {
                                      //Tengo que completar los siguientes campos
                                      No_Alumno = d.No__Estudiante,
                                      Alumno = d.Nombre,
                                      Padres = d.Padres_Tutor_a_,
                                      Celular = d.Celular
                                  }).AsQueryable();

                dgvTomarAsistencia.DataSource = sqlConsult.ToList();
            }

        }
        private void frm_TomarAsistencia_Load(object sender, EventArgs e)
        {
            Cargar_Cursos();
;
        }

        private void cbCurso_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvTomarAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        int contador;
        private void ContarAsitencia()
        {
            int x;
            x = dgvExisteAsistencia.Rows.Count;
            contador = x;
        }
        private bool existe()
        {
            string fecha = dtFecha.Value.ToString("dd/MM/yyyy");
            using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
            {
                var sql = from d in db.Asistencia
                          where d.Fecha_Asistencia == fecha
                          where d.Curso == cbCurso.Text
                          select d;
                dgvExisteAsistencia.DataSource = sql.ToList();
                ContarAsitencia();
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
        private void dgvTomarAsistencia_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvTomarAsistencia.Columns["check"].Index)
            {
                bool estado = Convert.ToBoolean(dgvTomarAsistencia.SelectedCells[4].Value);
                try
                {
                    if (estado == true)
                    {
                        dgvTomarAsistencia.Rows[e.RowIndex].Cells[4].Value = false;
                    }
                    else
                    {
                        int row = e.RowIndex;
                        dgvTomarAsistencia.Rows[row].Cells[4].Value = true;
                    }
                }
                catch 
                {

                }
            }
        }
        private void GuardarAsistencia()
        {

            if (dgvTomarAsistencia.DataSource == "")
            {
                MessageBox.Show("Datos vacios, por favor consulta los datos.", "Verifica:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string Nombre;
            string asistencia;
            string fecha_asistencia;
            string curso;

            bool _existe = existe();
            if (_existe == true)
            {
                MessageBox.Show("Ya existe una asistencia guardada con los mismos datos de curso y fecha. Por favor guarda " +
                    "la asistencia de otra fecha o curso", "Verifica:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvTomarAsistencia.DataSource = "";
                lblContador.Text = "INACTIVO";
                
                dgvTomarAsistencia.Columns.Remove(dgvTomarAsistencia.Columns[0]);

                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("¿Estás seguro de querer guardar la asistencia?","Confirma:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {


                    try
                    {
                        for (int i = 0; i < dgvTomarAsistencia.Rows.Count; i++)
                        {
                            bool estado = Convert.ToBoolean(dgvTomarAsistencia.Rows[i].Cells[4].Value);
                            if (estado == true)
                            {
                                Nombre = dgvTomarAsistencia.Rows[i].Cells[1].Value.ToString();
                                asistencia = "SI";
                                fecha_asistencia = dtFecha.Value.ToString("dd/MM/yyyy");
                                curso = cbCurso.Text;
                                using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                                {
                                    Asistencia asis = new Asistencia();
                                    asis.Nombre_Estudiante = Nombre;
                                    asis.Asistencia1 = asistencia;
                                    asis.Fecha_Asistencia = fecha_asistencia;
                                    asis.Curso = curso;
                                    db.Asistencia.Add(asis);
                                    db.SaveChanges();
                                }
                            }
                            else
                            {
                                Nombre = dgvTomarAsistencia.Rows[i].Cells[1].Value.ToString();
                                asistencia = "NO";
                                fecha_asistencia = dtFecha.Value.ToString("dd/MM/yyyy");
                                curso = cbCurso.Text;
                                using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                                {
                                    Asistencia asis = new Asistencia();
                                    asis.Nombre_Estudiante = Nombre;
                                    asis.Asistencia1 = asistencia;
                                    asis.Fecha_Asistencia = fecha_asistencia;
                                    asis.Curso = curso;
                                    db.Asistencia.Add(asis);
                                    db.SaveChanges();
                                }
                            }
                        }

                        lblContador.Text = "INACTIVO";
                        MessageBox.Show("Asistencia guardada correctamente.", "CORRECTO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTomarAsistencia.DataSource = "";
                        lblContador.Text = "INACTIVO";

                        dgvTomarAsistencia.Columns.Remove(dgvTomarAsistencia.Columns[0]);
                    }
                    catch (Exception)
                    {

                    }
                    
                }
                else
                {
                    return;
                }
            }
        }
        private void btnGuardarAsistencia_Click(object sender, EventArgs e)
        {
            GuardarAsistencia();
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvTomarAsistencia.Rows.Count; i++)
                {
                    bool estado = Convert.ToBoolean(dgvTomarAsistencia.Rows[i].Cells[4].Value);
                    if (estado == false)
                    {
                        dgvTomarAsistencia.Rows[i].Cells[4].Value = true;
                    }
                    
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(cbCurso.Text == "")
            {
                MessageBox.Show("Por favor selecciona un curso a efectuar la asistencia", "Curso en espera:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            if (lblContador.Text == "Activo")
            {
                DialogResult r = MessageBox.Show("Ya hay registros a la espera de evaluacion, ¿Deseas continuar sin guardar los cambios?", "Evaluación en proceso...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (r == DialogResult.No)
                {
                    return;
                }
                dgvTomarAsistencia.DataSource = "";
                dgvTomarAsistencia.Columns.Remove(dgvTomarAsistencia.Columns[0]);
            }
           
            ListarEstudiantes();
                eliminar_Columna();
                Agregar_Columna();
                lblContador.Text = "Activo";
            
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTomarAsistencia.DataSource = "";
                eliminar_Columna();
                dgvTomarAsistencia.Columns.Remove(dgvTomarAsistencia.Columns[0]);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
