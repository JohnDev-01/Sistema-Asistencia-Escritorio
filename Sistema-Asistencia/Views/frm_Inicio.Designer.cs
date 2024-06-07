
namespace Sistema_Asistencia
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.pnBotones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datalistadoConexion = new System.Windows.Forms.DataGridView();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.btnConsultarAsistencia = new System.Windows.Forms.Button();
            this.btnConsultarPorEstudiante = new System.Windows.Forms.Button();
            this.btnCrearEstudiantes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.pnBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoConexion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AllowUserToDeleteRows = false;
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvEstudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstudiantes.ColumnHeadersHeight = 30;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstudiantes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEstudiantes.EnableHeadersVisualStyles = false;
            this.dgvEstudiantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvEstudiantes.Location = new System.Drawing.Point(0, 106);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstudiantes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvEstudiantes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstudiantes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dgvEstudiantes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEstudiantes.RowTemplate.ReadOnly = true;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(1411, 653);
            this.dgvEstudiantes.TabIndex = 46;
            // 
            // pnBotones
            // 
            this.pnBotones.AutoScroll = true;
            this.pnBotones.Controls.Add(this.panel1);
            this.pnBotones.Controls.Add(this.btnCursos);
            this.pnBotones.Controls.Add(this.btnRegistrarAsistencia);
            this.pnBotones.Controls.Add(this.btnConsultarPorEstudiante);
            this.pnBotones.Controls.Add(this.btnCrearEstudiantes);
            this.pnBotones.Controls.Add(this.btnConsultarAsistencia);
            this.pnBotones.Location = new System.Drawing.Point(3, 12);
            this.pnBotones.Name = "pnBotones";
            this.pnBotones.Size = new System.Drawing.Size(1408, 94);
            this.pnBotones.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datalistadoConexion);
            this.panel1.Location = new System.Drawing.Point(499, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 52;
            // 
            // datalistadoConexion
            // 
            this.datalistadoConexion.AllowUserToAddRows = false;
            this.datalistadoConexion.AllowUserToDeleteRows = false;
            this.datalistadoConexion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datalistadoConexion.BackgroundColor = System.Drawing.Color.White;
            this.datalistadoConexion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoConexion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datalistadoConexion.ColumnHeadersHeight = 30;
            this.datalistadoConexion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datalistadoConexion.EnableHeadersVisualStyles = false;
            this.datalistadoConexion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.datalistadoConexion.Location = new System.Drawing.Point(276, 3);
            this.datalistadoConexion.Name = "datalistadoConexion";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoConexion.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datalistadoConexion.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.datalistadoConexion.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistadoConexion.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.datalistadoConexion.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.datalistadoConexion.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datalistadoConexion.RowTemplate.ReadOnly = true;
            this.datalistadoConexion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoConexion.Size = new System.Drawing.Size(51, 17);
            this.datalistadoConexion.TabIndex = 47;
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.Transparent;
            this.btnCursos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCursos.BackgroundImage")));
            this.btnCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnCursos.ForeColor = System.Drawing.Color.Black;
            this.btnCursos.Location = new System.Drawing.Point(1155, 4);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(138, 80);
            this.btnCursos.TabIndex = 51;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarAsistencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarAsistencia.BackgroundImage")));
            this.btnRegistrarAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnRegistrarAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAsistencia.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarAsistencia.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(246, 4);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(254, 80);
            this.btnRegistrarAsistencia.TabIndex = 48;
            this.btnRegistrarAsistencia.Text = "Registrar Asistencia";
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = false;
            this.btnRegistrarAsistencia.Click += new System.EventHandler(this.btnRegistrarAsistencia_Click);
            // 
            // btnConsultarAsistencia
            // 
            this.btnConsultarAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarAsistencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarAsistencia.BackgroundImage")));
            this.btnConsultarAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnConsultarAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConsultarAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConsultarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAsistencia.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnConsultarAsistencia.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarAsistencia.Location = new System.Drawing.Point(506, 5);
            this.btnConsultarAsistencia.Name = "btnConsultarAsistencia";
            this.btnConsultarAsistencia.Size = new System.Drawing.Size(254, 80);
            this.btnConsultarAsistencia.TabIndex = 47;
            this.btnConsultarAsistencia.Text = "Consultar Asistencia";
            this.btnConsultarAsistencia.UseVisualStyleBackColor = false;
            this.btnConsultarAsistencia.Click += new System.EventHandler(this.btnConsultarAsistencia_Click);
            // 
            // btnConsultarPorEstudiante
            // 
            this.btnConsultarPorEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarPorEstudiante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarPorEstudiante.BackgroundImage")));
            this.btnConsultarPorEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarPorEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarPorEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultarPorEstudiante.FlatAppearance.BorderSize = 0;
            this.btnConsultarPorEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConsultarPorEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConsultarPorEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPorEstudiante.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnConsultarPorEstudiante.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarPorEstudiante.Location = new System.Drawing.Point(766, 5);
            this.btnConsultarPorEstudiante.Name = "btnConsultarPorEstudiante";
            this.btnConsultarPorEstudiante.Size = new System.Drawing.Size(385, 80);
            this.btnConsultarPorEstudiante.TabIndex = 50;
            this.btnConsultarPorEstudiante.Text = "Consultar Asistencia/Estudiante";
            this.btnConsultarPorEstudiante.UseVisualStyleBackColor = false;
            this.btnConsultarPorEstudiante.Click += new System.EventHandler(this.btnConsultarPorEstudiante_Click);
            // 
            // btnCrearEstudiantes
            // 
            this.btnCrearEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearEstudiantes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearEstudiantes.BackgroundImage")));
            this.btnCrearEstudiantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearEstudiantes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCrearEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnCrearEstudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCrearEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCrearEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEstudiantes.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnCrearEstudiantes.ForeColor = System.Drawing.Color.Black;
            this.btnCrearEstudiantes.Location = new System.Drawing.Point(7, 4);
            this.btnCrearEstudiantes.Name = "btnCrearEstudiantes";
            this.btnCrearEstudiantes.Size = new System.Drawing.Size(233, 80);
            this.btnCrearEstudiantes.TabIndex = 49;
            this.btnCrearEstudiantes.Text = "Crear Estudiante";
            this.btnCrearEstudiantes.UseVisualStyleBackColor = false;
            this.btnCrearEstudiantes.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pnBotones);
            this.panel2.Controls.Add(this.dgvEstudiantes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 730);
            this.panel2.TabIndex = 48;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1319, 730);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicio_FormClosed);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.pnBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoConexion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Panel pnBotones;
        internal System.Windows.Forms.Button btnRegistrarAsistencia;
        internal System.Windows.Forms.Button btnConsultarAsistencia;
        internal System.Windows.Forms.Button btnConsultarPorEstudiante;
        internal System.Windows.Forms.Button btnCrearEstudiantes;
        internal System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datalistadoConexion;
    }
}

