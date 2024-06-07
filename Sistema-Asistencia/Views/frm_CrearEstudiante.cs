using Sistema_Asistencia.Data_Access.Conection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Asistencia.Views
{
    public partial class frm_CrearEstudiante : Form
    {
        public frm_CrearEstudiante()
        {
            InitializeComponent();
        }
        string estado_editar_agregar;
        string estado_validacion_controles;
        int id_Estudiante;
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
            if (cbCurso.Items.Count == 0)
            {
               DialogResult Resul =  MessageBox.Show("No hay cursos aun disponible al cual agregar un estudiante " +
                    "por favor registra un curso. ¿Quieres hacerlo ahora?", "Inexistencia:", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if(Resul == DialogResult.Yes)
                {
                    frm_Cursos frm = new frm_Cursos();
                    frm.ShowDialog();
                    Cargar_Cursos();
                }
            }
        }
        private void Limpiar_Espacios()
        {
            txtnombre.Clear();
            txtPadres.Clear();
            txtcel.Clear();
            cbCurso.Text = "";
        }
        private void frm_CrearEstudiante_Load(object sender, EventArgs e)
        {
            Cargar_Cursos();
            lblAqui.Visible = false;
            Limpiar_Espacios();
            Deshabilitar_Controles();
        }

        private void frm_CrearEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmInicio frm = new frmInicio();
            Dispose();
            frm.ShowDialog();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEstudiantes_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiantesParaEditar frm = new frmBuscarEstudiantesParaEditar();
            frm.ShowDialog();
        }
        private void HabilitarControls()
        {
            txtnombre.Enabled = true;
            txtPadres.Enabled = true;
            txtcel.Enabled = true;
            cbCurso.Enabled = true;
            txtnombre.Focus();
        } 
        private void Deshabilitar_Controles()
        {
            txtnombre.Enabled = false;
            txtnombre.Clear();
            txtPadres.Enabled = false;
            txtPadres.Clear();
            txtcel.Enabled = false;
            txtcel.Clear();
            cbCurso.Enabled = false;
            cbCurso.Text = "";
            txtCodigo.Clear();
            txtCodigo.Focus();
        }
        private void Validar_Espacios()
        {
            //Para Validar Solo el curso
            if (cbCurso.Text == "")
            {
                MessageBox.Show("Por favor selecciona un curso");
                lblAqui.Visible = true;
                estado_validacion_controles = "-";
                return;
            }
            else
            {
                lblAqui.Visible = false;
                estado_validacion_controles = "Coreccto";
            }
            //-----------------------------------------Nombre
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Por favor proporciona un nombre");
                estado_validacion_controles = "-";
                return;
            }
            else
            {
                lblAqui.Visible = false;
                estado_validacion_controles = "Coreccto";
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

          
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            
        }
        private void Find_Student()
        {
            try
            {
                id_Estudiante = Convert.ToInt32(txtCodigo.Text);
                using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                {
                    Estudiantes _est = new Estudiantes();
                    _est = db.Estudiantes.Find(id_Estudiante);
                    txtnombre.Text = _est.Nombre;
                    txtPadres.Text = _est.Padres_Tutor_a_;
                    txtcel.Text = _est.Celular;
                    cbCurso.Text = _est.Grado;
                    txtCodigo.Clear();
                    HabilitarControls();
                    if (txtnombre.Text != "")
                    {
                        estado_editar_agregar = "EDITAR";
                    }
                    else
                    {
                        estado_editar_agregar = "AGREGAR";
                    }
                }
            }
            catch (Exception)
            {

               
            }
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) & txtCodigo.Text == "")
            {
                HabilitarControls();
                estado_editar_agregar = "AGREGAR";
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter) & txtCodigo.Text != "")
            {
                Find_Student();
            }
                   
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validar_Espacios();

            if (estado_validacion_controles != "-")
            {

                if (estado_editar_agregar == "AGREGAR")
                {

                    using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                    {
                        Estudiantes est = new Estudiantes();
                        est.Nombre = txtnombre.Text;
                        est.Padres_Tutor_a_ = txtPadres.Text;
                        est.Celular = txtcel.Text;
                        est.Grado = cbCurso.Text;
                        est.Habilitado = "SI";
                        db.Estudiantes.Add(est);
                        db.SaveChanges();
                    }
                    Limpiar_Espacios();
                    Deshabilitar_Controles();
                }
                else if (estado_editar_agregar == "EDITAR")
                {

                    using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
                    {
                        Estudiantes _c = new Estudiantes();
                        _c = db.Estudiantes.Find(id_Estudiante);
                        _c.Nombre = txtnombre.Text;
                        _c.Padres_Tutor_a_ = txtPadres.Text;
                        _c.Grado = cbCurso.Text;
                        _c.Celular = txtcel.Text;
                        db.Entry(_c).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        Deshabilitar_Controles();
                    }

                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar_Espacios();
            Deshabilitar_Controles();
        }
    }
}
