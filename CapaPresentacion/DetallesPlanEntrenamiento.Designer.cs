
namespace CapaPresentacion
{
    partial class DetallesPlanEntrenamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvdataCoach = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cantCoachs = new System.Windows.Forms.Label();
            this.cantEjercicios = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewEjercicios = new System.Windows.Forms.DataGridView();
            this.idEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataCoach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEjercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdataCoach
            // 
            this.dgvdataCoach.AllowUserToAddRows = false;
            this.dgvdataCoach.AllowUserToDeleteRows = false;
            this.dgvdataCoach.AllowUserToResizeColumns = false;
            this.dgvdataCoach.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdataCoach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvdataCoach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdataCoach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataCoach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvdataCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataCoach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Email,
            this.FechaNacimiento,
            this.Telefono});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdataCoach.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvdataCoach.Location = new System.Drawing.Point(12, 203);
            this.dgvdataCoach.MultiSelect = false;
            this.dgvdataCoach.Name = "dgvdataCoach";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataCoach.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvdataCoach.RowHeadersWidth = 30;
            this.dgvdataCoach.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvdataCoach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdataCoach.Size = new System.Drawing.Size(517, 159);
            this.dgvdataCoach.TabIndex = 47;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "IdUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idUsuario.Visible = false;
            this.idUsuario.Width = 66;
            // 
            // Nombre
            // 
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle19;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 58;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Apellido.Width = 57;
            // 
            // DNI
            // 
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.DNI.DefaultCellStyle = dataGridViewCellStyle20;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DNI.Width = 34;
            // 
            // Email
            // 
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.Email.DefaultCellStyle = dataGridViewCellStyle21;
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Email.Width = 49;
            // 
            // FechaNacimiento
            // 
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.FechaNacimiento.DefaultCellStyle = dataGridViewCellStyle22;
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaNacimiento.Width = 102;
            // 
            // Telefono
            // 
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle23;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Telefono.Width = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "COACHS ASOCIADOS:";
            // 
            // cantCoachs
            // 
            this.cantCoachs.AutoSize = true;
            this.cantCoachs.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantCoachs.Location = new System.Drawing.Point(146, 182);
            this.cantCoachs.Name = "cantCoachs";
            this.cantCoachs.Size = new System.Drawing.Size(15, 17);
            this.cantCoachs.TabIndex = 49;
            this.cantCoachs.Text = "0";
            // 
            // cantEjercicios
            // 
            this.cantEjercicios.AutoSize = true;
            this.cantEjercicios.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantEjercicios.Location = new System.Drawing.Point(164, 9);
            this.cantEjercicios.Name = "cantEjercicios";
            this.cantEjercicios.Size = new System.Drawing.Size(15, 17);
            this.cantEjercicios.TabIndex = 51;
            this.cantEjercicios.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "EJERCICIOS ASOCIADOS:";
            // 
            // dataGridViewEjercicios
            // 
            this.dataGridViewEjercicios.AllowUserToAddRows = false;
            this.dataGridViewEjercicios.AllowUserToDeleteRows = false;
            this.dataGridViewEjercicios.AllowUserToResizeColumns = false;
            this.dataGridViewEjercicios.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewEjercicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewEjercicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEjercicios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEjercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEjercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEjercicio,
            this.dataGridViewTextBoxColumn1,
            this.repeticiones,
            this.tiempo});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEjercicios.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewEjercicios.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewEjercicios.MultiSelect = false;
            this.dataGridViewEjercicios.Name = "dataGridViewEjercicios";
            this.dataGridViewEjercicios.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEjercicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewEjercicios.RowHeadersWidth = 30;
            this.dataGridViewEjercicios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewEjercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEjercicios.Size = new System.Drawing.Size(517, 143);
            this.dataGridViewEjercicios.TabIndex = 52;
            // 
            // idEjercicio
            // 
            this.idEjercicio.HeaderText = "ID";
            this.idEjercicio.Name = "idEjercicio";
            this.idEjercicio.ReadOnly = true;
            this.idEjercicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idEjercicio.Visible = false;
            this.idEjercicio.Width = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 58;
            // 
            // repeticiones
            // 
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.repeticiones.DefaultCellStyle = dataGridViewCellStyle29;
            this.repeticiones.HeaderText = "Repeticiones";
            this.repeticiones.Name = "repeticiones";
            this.repeticiones.ReadOnly = true;
            this.repeticiones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.repeticiones.Width = 85;
            // 
            // tiempo
            // 
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            this.tiempo.DefaultCellStyle = dataGridViewCellStyle30;
            this.tiempo.HeaderText = "Tiempo en segundos";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            this.tiempo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tiempo.Width = 116;
            // 
            // DetallesPlanEntrenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 377);
            this.Controls.Add(this.dataGridViewEjercicios);
            this.Controls.Add(this.cantEjercicios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantCoachs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdataCoach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetallesPlanEntrenamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLES";
            this.Load += new System.EventHandler(this.DetallesPlanEntrenamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataCoach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEjercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdataCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cantCoachs;
        private System.Windows.Forms.Label cantEjercicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewEjercicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEjercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
    }
}