
namespace CapaPresentacion
{
    partial class DetallesNuevoAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxTipoMembresia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BAgregarEjercicio = new FontAwesome.Sharp.IconButton();
            this.BAgregarCoach = new FontAwesome.Sharp.IconButton();
            this.dataGridCoachSeleccionados = new System.Windows.Forms.DataGridView();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BConfirmarAlumno = new FontAwesome.Sharp.IconButton();
            this.dgvdataListaPlanes = new System.Windows.Forms.DataGridView();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesPlan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCoachSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataListaPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipoMembresia
            // 
            this.comboBoxTipoMembresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoMembresia.FormattingEnabled = true;
            this.comboBoxTipoMembresia.Location = new System.Drawing.Point(159, 371);
            this.comboBoxTipoMembresia.Name = "comboBoxTipoMembresia";
            this.comboBoxTipoMembresia.Size = new System.Drawing.Size(200, 26);
            this.comboBoxTipoMembresia.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(14, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "TIPO MEMBRESIA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdataListaPlanes);
            this.groupBox1.Controls.Add(this.BAgregarEjercicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 167);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLAN DE ENTRENAMIENTO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BAgregarCoach);
            this.groupBox2.Controls.Add(this.dataGridCoachSeleccionados);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 167);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COACH A CARGO";
            // 
            // BAgregarEjercicio
            // 
            this.BAgregarEjercicio.BackColor = System.Drawing.Color.OrangeRed;
            this.BAgregarEjercicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregarEjercicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BAgregarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarEjercicio.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarEjercicio.ForeColor = System.Drawing.Color.White;
            this.BAgregarEjercicio.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BAgregarEjercicio.IconColor = System.Drawing.Color.White;
            this.BAgregarEjercicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BAgregarEjercicio.IconSize = 30;
            this.BAgregarEjercicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BAgregarEjercicio.Location = new System.Drawing.Point(672, 25);
            this.BAgregarEjercicio.Name = "BAgregarEjercicio";
            this.BAgregarEjercicio.Size = new System.Drawing.Size(98, 71);
            this.BAgregarEjercicio.TabIndex = 49;
            this.BAgregarEjercicio.Text = "AGREGAR PLAN";
            this.BAgregarEjercicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BAgregarEjercicio.UseVisualStyleBackColor = false;
            // 
            // BAgregarCoach
            // 
            this.BAgregarCoach.BackColor = System.Drawing.Color.OrangeRed;
            this.BAgregarCoach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregarCoach.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BAgregarCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarCoach.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarCoach.ForeColor = System.Drawing.Color.White;
            this.BAgregarCoach.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BAgregarCoach.IconColor = System.Drawing.Color.White;
            this.BAgregarCoach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BAgregarCoach.IconSize = 30;
            this.BAgregarCoach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BAgregarCoach.Location = new System.Drawing.Point(672, 25);
            this.BAgregarCoach.Name = "BAgregarCoach";
            this.BAgregarCoach.Size = new System.Drawing.Size(98, 71);
            this.BAgregarCoach.TabIndex = 48;
            this.BAgregarCoach.Text = "AGREGAR COACH";
            this.BAgregarCoach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BAgregarCoach.UseVisualStyleBackColor = false;
            // 
            // dataGridCoachSeleccionados
            // 
            this.dataGridCoachSeleccionados.AllowUserToAddRows = false;
            this.dataGridCoachSeleccionados.AllowUserToDeleteRows = false;
            this.dataGridCoachSeleccionados.AllowUserToResizeColumns = false;
            this.dataGridCoachSeleccionados.AllowUserToResizeRows = false;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCoachSeleccionados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridCoachSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCoachSeleccionados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCoachSeleccionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridCoachSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCoachSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar,
            this.idUsuario,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCoachSeleccionados.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridCoachSeleccionados.Location = new System.Drawing.Point(6, 25);
            this.dataGridCoachSeleccionados.MultiSelect = false;
            this.dataGridCoachSeleccionados.Name = "dataGridCoachSeleccionados";
            this.dataGridCoachSeleccionados.ReadOnly = true;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCoachSeleccionados.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dataGridCoachSeleccionados.RowHeadersWidth = 30;
            this.dataGridCoachSeleccionados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridCoachSeleccionados.RowTemplate.Height = 30;
            this.dataGridCoachSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCoachSeleccionados.Size = new System.Drawing.Size(660, 125);
            this.dataGridCoachSeleccionados.TabIndex = 49;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Accion";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Width = 68;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "IdUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idUsuario.Visible = false;
            this.idUsuario.Width = 66;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 58;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewTextBoxColumn3.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 34;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewTextBoxColumn4.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 49;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha Nacimiento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 102;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 61;
            // 
            // BConfirmarAlumno
            // 
            this.BConfirmarAlumno.BackColor = System.Drawing.Color.Green;
            this.BConfirmarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BConfirmarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BConfirmarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BConfirmarAlumno.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConfirmarAlumno.ForeColor = System.Drawing.Color.White;
            this.BConfirmarAlumno.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BConfirmarAlumno.IconColor = System.Drawing.Color.White;
            this.BConfirmarAlumno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BConfirmarAlumno.IconSize = 35;
            this.BConfirmarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BConfirmarAlumno.Location = new System.Drawing.Point(653, 366);
            this.BConfirmarAlumno.Name = "BConfirmarAlumno";
            this.BConfirmarAlumno.Size = new System.Drawing.Size(135, 35);
            this.BConfirmarAlumno.TabIndex = 27;
            this.BConfirmarAlumno.Text = "FINALIZAR";
            this.BConfirmarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BConfirmarAlumno.UseVisualStyleBackColor = false;
            this.BConfirmarAlumno.Click += new System.EventHandler(this.BConfirmarAlumno_Click);
            // 
            // dgvdataListaPlanes
            // 
            this.dgvdataListaPlanes.AllowUserToAddRows = false;
            this.dgvdataListaPlanes.AllowUserToDeleteRows = false;
            this.dgvdataListaPlanes.AllowUserToResizeColumns = false;
            this.dgvdataListaPlanes.AllowUserToResizeRows = false;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdataListaPlanes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle44;
            this.dgvdataListaPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdataListaPlanes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataListaPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.dgvdataListaPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataListaPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accion,
            this.idPlan,
            this.Nombre,
            this.fechaInicio,
            this.fechaFin,
            this.series,
            this.detallesPlan});
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdataListaPlanes.DefaultCellStyle = dataGridViewCellStyle50;
            this.dgvdataListaPlanes.Location = new System.Drawing.Point(6, 25);
            this.dgvdataListaPlanes.MultiSelect = false;
            this.dgvdataListaPlanes.Name = "dgvdataListaPlanes";
            this.dgvdataListaPlanes.ReadOnly = true;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataListaPlanes.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.dgvdataListaPlanes.RowHeadersWidth = 30;
            this.dgvdataListaPlanes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvdataListaPlanes.RowTemplate.Height = 30;
            this.dgvdataListaPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdataListaPlanes.Size = new System.Drawing.Size(660, 125);
            this.dgvdataListaPlanes.TabIndex = 50;
            // 
            // accion
            // 
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.Black;
            this.accion.DefaultCellStyle = dataGridViewCellStyle46;
            this.accion.HeaderText = "Accion";
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            this.accion.Width = 55;
            // 
            // idPlan
            // 
            this.idPlan.HeaderText = "Idplan";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            this.idPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idPlan.Visible = false;
            this.idPlan.Width = 51;
            // 
            // Nombre
            // 
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle47;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 63;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaInicio.Width = 77;
            // 
            // fechaFin
            // 
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.Black;
            this.fechaFin.DefaultCellStyle = dataGridViewCellStyle48;
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            this.fechaFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaFin.Width = 66;
            // 
            // series
            // 
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.Black;
            this.series.DefaultCellStyle = dataGridViewCellStyle49;
            this.series.HeaderText = "Series";
            this.series.Name = "series";
            this.series.ReadOnly = true;
            this.series.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.series.Width = 53;
            // 
            // detallesPlan
            // 
            this.detallesPlan.HeaderText = "Ejercicios / Coach";
            this.detallesPlan.Name = "detallesPlan";
            this.detallesPlan.ReadOnly = true;
            this.detallesPlan.Text = "";
            this.detallesPlan.Width = 75;
            // 
            // DetallesNuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.BConfirmarAlumno);
            this.Controls.Add(this.comboBoxTipoMembresia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetallesNuevoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO ALUMNO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCoachSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataListaPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoMembresia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton BAgregarEjercicio;
        private FontAwesome.Sharp.IconButton BAgregarCoach;
        private System.Windows.Forms.DataGridView dataGridCoachSeleccionados;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private FontAwesome.Sharp.IconButton BConfirmarAlumno;
        private System.Windows.Forms.DataGridView dgvdataListaPlanes;
        private System.Windows.Forms.DataGridViewButtonColumn accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn series;
        private System.Windows.Forms.DataGridViewButtonColumn detallesPlan;
    }
}