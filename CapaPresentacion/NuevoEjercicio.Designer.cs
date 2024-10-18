
namespace CapaPresentacion
{
    partial class Ejercicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BGuardarEjercicio = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.BCancelar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRepeticiones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombreEjercicio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LnombreColumna = new System.Windows.Forms.Label();
            this.LBuscar = new System.Windows.Forms.Label();
            this.dataGridViewEjercicios = new System.Windows.Forms.DataGridView();
            this.idEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.BLimpiar = new FontAwesome.Sharp.IconButton();
            this.Bbuscar = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEjercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // BGuardarEjercicio
            // 
            this.BGuardarEjercicio.BackColor = System.Drawing.Color.Green;
            this.BGuardarEjercicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardarEjercicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarEjercicio.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarEjercicio.ForeColor = System.Drawing.Color.White;
            this.BGuardarEjercicio.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BGuardarEjercicio.IconColor = System.Drawing.Color.White;
            this.BGuardarEjercicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardarEjercicio.IconSize = 30;
            this.BGuardarEjercicio.Location = new System.Drawing.Point(48, 211);
            this.BGuardarEjercicio.Name = "BGuardarEjercicio";
            this.BGuardarEjercicio.Size = new System.Drawing.Size(35, 35);
            this.BGuardarEjercicio.TabIndex = 29;
            this.BGuardarEjercicio.UseVisualStyleBackColor = false;
            this.BGuardarEjercicio.Click += new System.EventHandler(this.BGuardarEjercicio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.BGuardarEjercicio);
            this.groupBox1.Controls.Add(this.textBoxTiempo);
            this.groupBox1.Controls.Add(this.BCancelar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxRepeticiones);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNombreEjercicio);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 258);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar nuevo ejercicio";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.White;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(187, 222);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(24, 24);
            this.textBoxID.TabIndex = 58;
            this.textBoxID.Text = "0";
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.BackColor = System.Drawing.Color.White;
            this.textBoxTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTiempo.Location = new System.Drawing.Point(6, 171);
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.Size = new System.Drawing.Size(205, 24);
            this.textBoxTiempo.TabIndex = 57;
            this.textBoxTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTiempo_KeyPress);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BCancelar.IconColor = System.Drawing.Color.White;
            this.BCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCancelar.IconSize = 30;
            this.BCancelar.Location = new System.Drawing.Point(7, 211);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(35, 35);
            this.BCancelar.TabIndex = 28;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tiempo (en segundos):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Repeticiones:";
            // 
            // textBoxRepeticiones
            // 
            this.textBoxRepeticiones.BackColor = System.Drawing.Color.White;
            this.textBoxRepeticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepeticiones.Location = new System.Drawing.Point(6, 106);
            this.textBoxRepeticiones.Name = "textBoxRepeticiones";
            this.textBoxRepeticiones.Size = new System.Drawing.Size(205, 24);
            this.textBoxRepeticiones.TabIndex = 43;
            this.textBoxRepeticiones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRepeticiones_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre del ejercicio:";
            // 
            // textBoxNombreEjercicio
            // 
            this.textBoxNombreEjercicio.BackColor = System.Drawing.Color.White;
            this.textBoxNombreEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreEjercicio.Location = new System.Drawing.Point(6, 43);
            this.textBoxNombreEjercicio.Name = "textBoxNombreEjercicio";
            this.textBoxNombreEjercicio.Size = new System.Drawing.Size(205, 24);
            this.textBoxNombreEjercicio.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LnombreColumna);
            this.groupBox2.Controls.Add(this.LBuscar);
            this.groupBox2.Controls.Add(this.dataGridViewEjercicios);
            this.groupBox2.Controls.Add(this.textBoxBuscar);
            this.groupBox2.Controls.Add(this.BLimpiar);
            this.groupBox2.Controls.Add(this.Bbuscar);
            this.groupBox2.Location = new System.Drawing.Point(235, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 258);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de ejercicios";
            // 
            // LnombreColumna
            // 
            this.LnombreColumna.AutoSize = true;
            this.LnombreColumna.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LnombreColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnombreColumna.ForeColor = System.Drawing.Color.Red;
            this.LnombreColumna.Location = new System.Drawing.Point(166, 30);
            this.LnombreColumna.Name = "LnombreColumna";
            this.LnombreColumna.Size = new System.Drawing.Size(93, 15);
            this.LnombreColumna.TabIndex = 49;
            this.LnombreColumna.Text = "Nombre campo";
            this.LnombreColumna.Visible = false;
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.Location = new System.Drawing.Point(96, 30);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(69, 15);
            this.LBuscar.TabIndex = 48;
            this.LBuscar.Text = "Buscar por:";
            this.LBuscar.Visible = false;
            // 
            // dataGridViewEjercicios
            // 
            this.dataGridViewEjercicios.AllowUserToAddRows = false;
            this.dataGridViewEjercicios.AllowUserToDeleteRows = false;
            this.dataGridViewEjercicios.AllowUserToResizeColumns = false;
            this.dataGridViewEjercicios.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewEjercicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewEjercicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEjercicios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEjercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEjercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEjercicio,
            this.nombre,
            this.repeticiones,
            this.tiempo,
            this.editar,
            this.eliminar});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEjercicios.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewEjercicios.Location = new System.Drawing.Point(6, 57);
            this.dataGridViewEjercicios.MultiSelect = false;
            this.dataGridViewEjercicios.Name = "dataGridViewEjercicios";
            this.dataGridViewEjercicios.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEjercicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewEjercicios.RowHeadersWidth = 30;
            this.dataGridViewEjercicios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewEjercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEjercicios.Size = new System.Drawing.Size(510, 189);
            this.dataGridViewEjercicios.TabIndex = 47;
            this.dataGridViewEjercicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEjercicios_CellContentClick);
            this.dataGridViewEjercicios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEjercicios_CellDoubleClick);
            this.dataGridViewEjercicios.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEjercicios_ColumnHeaderMouseClick);
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
            // nombre
            // 
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle24;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombre.Width = 58;
            // 
            // repeticiones
            // 
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.repeticiones.DefaultCellStyle = dataGridViewCellStyle25;
            this.repeticiones.HeaderText = "Repeticiones";
            this.repeticiones.Name = "repeticiones";
            this.repeticiones.ReadOnly = true;
            this.repeticiones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.repeticiones.Width = 85;
            // 
            // tiempo
            // 
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.tiempo.DefaultCellStyle = dataGridViewCellStyle26;
            this.tiempo.HeaderText = "Tiempo en segundos";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            this.tiempo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tiempo.Width = 116;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.Width = 45;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.Width = 59;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(260, 25);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(175, 24);
            this.textBoxBuscar.TabIndex = 45;
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.ForeColor = System.Drawing.Color.White;
            this.BLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BLimpiar.IconColor = System.Drawing.Color.White;
            this.BLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BLimpiar.IconSize = 25;
            this.BLimpiar.Location = new System.Drawing.Point(478, 23);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(35, 26);
            this.BLimpiar.TabIndex = 44;
            this.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // Bbuscar
            // 
            this.Bbuscar.BackColor = System.Drawing.Color.LimeGreen;
            this.Bbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Bbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bbuscar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbuscar.ForeColor = System.Drawing.Color.White;
            this.Bbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.Bbuscar.IconColor = System.Drawing.Color.White;
            this.Bbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bbuscar.IconSize = 20;
            this.Bbuscar.Location = new System.Drawing.Point(441, 23);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(35, 26);
            this.Bbuscar.TabIndex = 43;
            this.Bbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bbuscar.UseVisualStyleBackColor = false;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // Ejercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ejercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR EJERCICIO";
            this.Load += new System.EventHandler(this.Ejercicios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEjercicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BGuardarEjercicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton BCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRepeticiones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNombreEjercicio;
        private System.Windows.Forms.TextBox textBoxTiempo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private FontAwesome.Sharp.IconButton BLimpiar;
        private FontAwesome.Sharp.IconButton Bbuscar;
        private System.Windows.Forms.DataGridView dataGridViewEjercicios;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label LnombreColumna;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEjercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}