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

namespace Sistema_Asistencia.Views
{
    
    public partial class frmBuscarEstudiante_Para_Consultar : Form
    {
        public frmBuscarEstudiante_Para_Consultar()
        {
            InitializeComponent();
        }
        private void Listar_Students()
        {
            using (Sistema_Asistencia_ProfesorEntities db = new Sistema_Asistencia_ProfesorEntities())
            {
                var sqlConsult = (from d in db.Estudiantes
                                 where d.Nombre == txtBuscar.Text
                                 select new _StudentsName
                                 {
                                     ID = d.No__Estudiante,
                                     Nombre = d.Nombre
                                 });
                dgvBuscarEstudiantes.DataSource = sqlConsult.ToList();
            }
            dgvBuscarEstudiantes.Columns[0].Visible = false;
        }
        private void frmBuscarEstudiante_Para_Consultar_Load(object sender, EventArgs e)
        {
            Listar_Students();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar_Students();
        }
    }
    public class _StudentsName
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}
