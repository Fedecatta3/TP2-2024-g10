
namespace CapaPresentacion
{
    partial class NuevoRol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BCancelar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombreRol = new System.Windows.Forms.TextBox();
            this.BGuardarRol = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BCancelar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNombreRol);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 151);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
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
            this.BCancelar.Location = new System.Drawing.Point(358, 97);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(35, 35);
            this.BCancelar.TabIndex = 28;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(15, 108);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(177, 24);
            this.comboBoxEstado.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(212, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Fecha:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.BackColor = System.Drawing.Color.White;
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(216, 43);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(177, 24);
            this.textBoxFecha.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre rol:";
            // 
            // textBoxNombreRol
            // 
            this.textBoxNombreRol.BackColor = System.Drawing.Color.White;
            this.textBoxNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreRol.Location = new System.Drawing.Point(15, 43);
            this.textBoxNombreRol.Name = "textBoxNombreRol";
            this.textBoxNombreRol.Size = new System.Drawing.Size(177, 24);
            this.textBoxNombreRol.TabIndex = 41;
            // 
            // BGuardarRol
            // 
            this.BGuardarRol.BackColor = System.Drawing.Color.Green;
            this.BGuardarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardarRol.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarRol.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarRol.ForeColor = System.Drawing.Color.White;
            this.BGuardarRol.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BGuardarRol.IconColor = System.Drawing.Color.White;
            this.BGuardarRol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardarRol.IconSize = 30;
            this.BGuardarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardarRol.Location = new System.Drawing.Point(159, 172);
            this.BGuardarRol.Name = "BGuardarRol";
            this.BGuardarRol.Size = new System.Drawing.Size(118, 57);
            this.BGuardarRol.TabIndex = 29;
            this.BGuardarRol.Text = "GUARDAR";
            this.BGuardarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardarRol.UseVisualStyleBackColor = false;
            this.BGuardarRol.Click += new System.EventHandler(this.BGuardarRol_Click);
            // 
            // NuevoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.Controls.Add(this.BGuardarRol);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NuevoRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo Rol";
            this.Load += new System.EventHandler(this.NuevoRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BGuardarRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton BCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNombreRol;
    }
}