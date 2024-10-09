
namespace CapaPresentacion
{
    partial class ListaAlumnos
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
            this.label13 = new System.Windows.Forms.Label();
            this.DGV_Alumnos = new System.Windows.Forms.DataGridView();
            this.IDusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BVerFicha = new FontAwesome.Sharp.IconButton();
            this.BNuevoAlumno = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.OrangeRed;
            this.label13.Location = new System.Drawing.Point(12, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(765, 40);
            this.label13.TabIndex = 28;
            this.label13.Text = "LISTA DE ALUMNOS";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGV_Alumnos
            // 
            this.DGV_Alumnos.AllowUserToAddRows = false;
            this.DGV_Alumnos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDusuario,
            this.NombreCompleto,
            this.DNI,
            this.Email,
            this.Telefono,
            this.Accion});
            this.DGV_Alumnos.Location = new System.Drawing.Point(12, 51);
            this.DGV_Alumnos.MultiSelect = false;
            this.DGV_Alumnos.Name = "DGV_Alumnos";
            this.DGV_Alumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DGV_Alumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Alumnos.Size = new System.Drawing.Size(766, 394);
            this.DGV_Alumnos.TabIndex = 27;
            // 
            // IDusuario
            // 
            this.IDusuario.HeaderText = "IDusuario";
            this.IDusuario.Name = "IDusuario";
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Width = 180;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.Width = 180;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.Width = 110;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(728, 12);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 24);
            this.iconButton2.TabIndex = 34;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(677, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 24);
            this.iconButton1.TabIndex = 33;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(491, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 24);
            this.textBox8.TabIndex = 30;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(316, 12);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(169, 26);
            this.comboBox4.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(246, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Buscar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cantidad de alumnos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(165, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "0 alumnos";
            // 
            // BVerFicha
            // 
            this.BVerFicha.BackColor = System.Drawing.Color.OrangeRed;
            this.BVerFicha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVerFicha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BVerFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVerFicha.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVerFicha.ForeColor = System.Drawing.Color.White;
            this.BVerFicha.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BVerFicha.IconColor = System.Drawing.Color.White;
            this.BVerFicha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BVerFicha.IconSize = 30;
            this.BVerFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVerFicha.Location = new System.Drawing.Point(336, 456);
            this.BVerFicha.Name = "BVerFicha";
            this.BVerFicha.Size = new System.Drawing.Size(97, 34);
            this.BVerFicha.TabIndex = 37;
            this.BVerFicha.Text = "VER FICHA";
            this.BVerFicha.UseVisualStyleBackColor = false;
            this.BVerFicha.Click += new System.EventHandler(this.BVerFicha_Click);
            // 
            // BNuevoAlumno
            // 
            this.BNuevoAlumno.BackColor = System.Drawing.Color.Green;
            this.BNuevoAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNuevoAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BNuevoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevoAlumno.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoAlumno.ForeColor = System.Drawing.Color.White;
            this.BNuevoAlumno.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BNuevoAlumno.IconColor = System.Drawing.Color.White;
            this.BNuevoAlumno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BNuevoAlumno.IconSize = 30;
            this.BNuevoAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BNuevoAlumno.Location = new System.Drawing.Point(624, 451);
            this.BNuevoAlumno.Name = "BNuevoAlumno";
            this.BNuevoAlumno.Size = new System.Drawing.Size(154, 45);
            this.BNuevoAlumno.TabIndex = 40;
            this.BNuevoAlumno.Text = "NUEVO ALUMNO";
            this.BNuevoAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNuevoAlumno.UseVisualStyleBackColor = false;
            this.BNuevoAlumno.Click += new System.EventHandler(this.BNuevoAlumno_Click);
            // 
            // ListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 507);
            this.Controls.Add(this.BNuevoAlumno);
            this.Controls.Add(this.BVerFicha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DGV_Alumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaAlumnos";
            this.Text = "ListaAlumnos";
            this.Load += new System.EventHandler(this.ListaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DGV_Alumnos;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BVerFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private FontAwesome.Sharp.IconButton BNuevoAlumno;
    }
}