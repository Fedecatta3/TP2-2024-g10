
namespace CapaPresentacion
{
    partial class AgregarCoachAlPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvdataAgregarCoach = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blimpiar = new FontAwesome.Sharp.IconButton();
            this.Bbuscar = new FontAwesome.Sharp.IconButton();
            this.LnombreColumna = new System.Windows.Forms.Label();
            this.LBuscar = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataAgregarCoach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdataAgregarCoach
            // 
            this.dgvdataAgregarCoach.AllowUserToAddRows = false;
            this.dgvdataAgregarCoach.AllowUserToDeleteRows = false;
            this.dgvdataAgregarCoach.AllowUserToResizeColumns = false;
            this.dgvdataAgregarCoach.AllowUserToResizeRows = false;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdataAgregarCoach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            this.dgvdataAgregarCoach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdataAgregarCoach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataAgregarCoach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dgvdataAgregarCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataAgregarCoach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Email,
            this.FechaNacimiento,
            this.Telefono});
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdataAgregarCoach.DefaultCellStyle = dataGridViewCellStyle53;
            this.dgvdataAgregarCoach.Location = new System.Drawing.Point(12, 49);
            this.dgvdataAgregarCoach.MultiSelect = false;
            this.dgvdataAgregarCoach.Name = "dgvdataAgregarCoach";
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataAgregarCoach.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.dgvdataAgregarCoach.RowHeadersWidth = 30;
            this.dgvdataAgregarCoach.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvdataAgregarCoach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdataAgregarCoach.Size = new System.Drawing.Size(544, 202);
            this.dgvdataAgregarCoach.TabIndex = 46;
            this.dgvdataAgregarCoach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdataAgregarCoach_CellDoubleClick);
            this.dgvdataAgregarCoach.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdataAgregarCoach_ColumnHeaderMouseClick);
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
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle48;
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
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.Black;
            this.DNI.DefaultCellStyle = dataGridViewCellStyle49;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DNI.Width = 34;
            // 
            // Email
            // 
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.Black;
            this.Email.DefaultCellStyle = dataGridViewCellStyle50;
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Email.Width = 49;
            // 
            // FechaNacimiento
            // 
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.Black;
            this.FechaNacimiento.DefaultCellStyle = dataGridViewCellStyle51;
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaNacimiento.Width = 102;
            // 
            // Telefono
            // 
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.Black;
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle52;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Telefono.Width = 61;
            // 
            // Blimpiar
            // 
            this.Blimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Blimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Blimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Blimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blimpiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blimpiar.ForeColor = System.Drawing.Color.White;
            this.Blimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.Blimpiar.IconColor = System.Drawing.Color.White;
            this.Blimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Blimpiar.IconSize = 25;
            this.Blimpiar.Location = new System.Drawing.Point(520, 14);
            this.Blimpiar.Name = "Blimpiar";
            this.Blimpiar.Size = new System.Drawing.Size(35, 26);
            this.Blimpiar.TabIndex = 50;
            this.Blimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Blimpiar.UseVisualStyleBackColor = false;
            this.Blimpiar.Click += new System.EventHandler(this.Blimpiar_Click);
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
            this.Bbuscar.Location = new System.Drawing.Point(483, 14);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(35, 26);
            this.Bbuscar.TabIndex = 49;
            this.Bbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bbuscar.UseVisualStyleBackColor = false;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // LnombreColumna
            // 
            this.LnombreColumna.AutoSize = true;
            this.LnombreColumna.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LnombreColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnombreColumna.ForeColor = System.Drawing.Color.Red;
            this.LnombreColumna.Location = new System.Drawing.Point(199, 20);
            this.LnombreColumna.Name = "LnombreColumna";
            this.LnombreColumna.Size = new System.Drawing.Size(93, 15);
            this.LnombreColumna.TabIndex = 53;
            this.LnombreColumna.Text = "Nombre campo";
            this.LnombreColumna.Visible = false;
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.Location = new System.Drawing.Point(129, 20);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(69, 15);
            this.LBuscar.TabIndex = 52;
            this.LBuscar.Text = "Buscar por:";
            this.LBuscar.Visible = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(302, 15);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(175, 24);
            this.textBoxBuscar.TabIndex = 51;
            // 
            // AgregarCoachAlPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(568, 263);
            this.Controls.Add(this.LnombreColumna);
            this.Controls.Add(this.LBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.Blimpiar);
            this.Controls.Add(this.Bbuscar);
            this.Controls.Add(this.dgvdataAgregarCoach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarCoachAlPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR COACH";
            this.Load += new System.EventHandler(this.AgregarCoachAlPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataAgregarCoach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdataAgregarCoach;
        private FontAwesome.Sharp.IconButton Blimpiar;
        private FontAwesome.Sharp.IconButton Bbuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Label LnombreColumna;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
    }
}