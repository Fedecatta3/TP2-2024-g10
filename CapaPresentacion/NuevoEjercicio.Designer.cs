
namespace CapaPresentacion
{
    partial class NuevoEjercicio
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
            this.BGuardarEjercicio = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMinutos = new System.Windows.Forms.CheckBox();
            this.checkBoxSegundos = new System.Windows.Forms.CheckBox();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.BCancelar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRepeticiones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombreEjercicio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            this.BGuardarEjercicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardarEjercicio.Location = new System.Drawing.Point(158, 191);
            this.BGuardarEjercicio.Name = "BGuardarEjercicio";
            this.BGuardarEjercicio.Size = new System.Drawing.Size(118, 57);
            this.BGuardarEjercicio.TabIndex = 29;
            this.BGuardarEjercicio.Text = "GUARDAR";
            this.BGuardarEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardarEjercicio.UseVisualStyleBackColor = false;
            this.BGuardarEjercicio.Click += new System.EventHandler(this.BGuardarEjercicio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMinutos);
            this.groupBox1.Controls.Add(this.checkBoxSegundos);
            this.groupBox1.Controls.Add(this.textBoxTiempo);
            this.groupBox1.Controls.Add(this.BCancelar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxRepeticiones);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNombreEjercicio);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 173);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxMinutos
            // 
            this.checkBoxMinutos.AutoSize = true;
            this.checkBoxMinutos.Location = new System.Drawing.Point(104, 142);
            this.checkBoxMinutos.Name = "checkBoxMinutos";
            this.checkBoxMinutos.Size = new System.Drawing.Size(63, 17);
            this.checkBoxMinutos.TabIndex = 59;
            this.checkBoxMinutos.Text = "Minutos";
            this.checkBoxMinutos.UseVisualStyleBackColor = true;
            // 
            // checkBoxSegundos
            // 
            this.checkBoxSegundos.AutoSize = true;
            this.checkBoxSegundos.Location = new System.Drawing.Point(24, 142);
            this.checkBoxSegundos.Name = "checkBoxSegundos";
            this.checkBoxSegundos.Size = new System.Drawing.Size(74, 17);
            this.checkBoxSegundos.TabIndex = 58;
            this.checkBoxSegundos.Text = "Segundos";
            this.checkBoxSegundos.UseVisualStyleBackColor = true;
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.BackColor = System.Drawing.Color.White;
            this.textBoxTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTiempo.Location = new System.Drawing.Point(15, 112);
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.Size = new System.Drawing.Size(177, 24);
            this.textBoxTiempo.TabIndex = 57;
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
            this.BCancelar.Location = new System.Drawing.Point(358, 124);
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
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Cantidad de tiempo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(212, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Repeticiones:";
            // 
            // textBoxRepeticiones
            // 
            this.textBoxRepeticiones.BackColor = System.Drawing.Color.White;
            this.textBoxRepeticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepeticiones.Location = new System.Drawing.Point(216, 43);
            this.textBoxRepeticiones.Name = "textBoxRepeticiones";
            this.textBoxRepeticiones.Size = new System.Drawing.Size(177, 24);
            this.textBoxRepeticiones.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre del ejercicio:";
            // 
            // textBoxNombreEjercicio
            // 
            this.textBoxNombreEjercicio.BackColor = System.Drawing.Color.White;
            this.textBoxNombreEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreEjercicio.Location = new System.Drawing.Point(15, 43);
            this.textBoxNombreEjercicio.Name = "textBoxNombreEjercicio";
            this.textBoxNombreEjercicio.Size = new System.Drawing.Size(177, 24);
            this.textBoxNombreEjercicio.TabIndex = 41;
            // 
            // NuevoEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 257);
            this.Controls.Add(this.BGuardarEjercicio);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NuevoEjercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Ejercicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBoxMinutos;
        private System.Windows.Forms.CheckBox checkBoxSegundos;
        private System.Windows.Forms.TextBox textBoxTiempo;
    }
}