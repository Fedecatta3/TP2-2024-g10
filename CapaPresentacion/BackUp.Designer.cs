
namespace CapaPresentacion
{
    partial class BackUp
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
            this.BGenerarBackup = new FontAwesome.Sharp.IconButton();
            this.BRutaBackup = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BConectar = new FontAwesome.Sharp.IconButton();
            this.comboBoxCoach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGenerarBackup
            // 
            this.BGenerarBackup.BackColor = System.Drawing.Color.OrangeRed;
            this.BGenerarBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarBackup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGenerarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGenerarBackup.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarBackup.ForeColor = System.Drawing.Color.White;
            this.BGenerarBackup.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BGenerarBackup.IconColor = System.Drawing.Color.White;
            this.BGenerarBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGenerarBackup.IconSize = 35;
            this.BGenerarBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGenerarBackup.Location = new System.Drawing.Point(358, 265);
            this.BGenerarBackup.Name = "BGenerarBackup";
            this.BGenerarBackup.Size = new System.Drawing.Size(160, 49);
            this.BGenerarBackup.TabIndex = 39;
            this.BGenerarBackup.Text = "GENERAR BACK-UP";
            this.BGenerarBackup.UseVisualStyleBackColor = false;
            this.BGenerarBackup.Click += new System.EventHandler(this.BGenerarBackup_Click);
            // 
            // BRutaBackup
            // 
            this.BRutaBackup.BackColor = System.Drawing.Color.DimGray;
            this.BRutaBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRutaBackup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BRutaBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRutaBackup.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRutaBackup.ForeColor = System.Drawing.Color.White;
            this.BRutaBackup.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BRutaBackup.IconColor = System.Drawing.Color.White;
            this.BRutaBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BRutaBackup.IconSize = 35;
            this.BRutaBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRutaBackup.Location = new System.Drawing.Point(591, 196);
            this.BRutaBackup.Name = "BRutaBackup";
            this.BRutaBackup.Size = new System.Drawing.Size(102, 26);
            this.BRutaBackup.TabIndex = 38;
            this.BRutaBackup.Text = "RUTA";
            this.BRutaBackup.UseVisualStyleBackColor = false;
            this.BRutaBackup.Click += new System.EventHandler(this.BRutaBackup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(161, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ruta de archivo:";
            // 
            // BConectar
            // 
            this.BConectar.BackColor = System.Drawing.Color.DimGray;
            this.BConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BConectar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BConectar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConectar.ForeColor = System.Drawing.Color.White;
            this.BConectar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BConectar.IconColor = System.Drawing.Color.White;
            this.BConectar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BConectar.IconSize = 35;
            this.BConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BConectar.Location = new System.Drawing.Point(591, 138);
            this.BConectar.Name = "BConectar";
            this.BConectar.Size = new System.Drawing.Size(102, 26);
            this.BConectar.TabIndex = 36;
            this.BConectar.Text = "CONECTAR";
            this.BConectar.UseVisualStyleBackColor = false;
            this.BConectar.Click += new System.EventHandler(this.BConectar_Click);
            // 
            // comboBoxCoach
            // 
            this.comboBoxCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCoach.FormattingEnabled = true;
            this.comboBoxCoach.Location = new System.Drawing.Point(300, 138);
            this.comboBoxCoach.Name = "comboBoxCoach";
            this.comboBoxCoach.Size = new System.Drawing.Size(276, 26);
            this.comboBoxCoach.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(176, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Base de datos:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(300, 198);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(276, 24);
            this.textBoxNombre.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 67);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(359, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "BACK-UP";
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 507);
            this.Controls.Add(this.BGenerarBackup);
            this.Controls.Add(this.BRutaBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BConectar);
            this.Controls.Add(this.comboBoxCoach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackUp";
            this.Text = "BackUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BGenerarBackup;
        private FontAwesome.Sharp.IconButton BRutaBackup;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BConectar;
        private System.Windows.Forms.ComboBox comboBoxCoach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}