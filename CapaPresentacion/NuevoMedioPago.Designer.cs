
namespace CapaPresentacion
{
    partial class NuevoMedioPago
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
            this.BGuardarMedioPago = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.BCancelar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombreMedioPago = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGuardarMedioPago
            // 
            this.BGuardarMedioPago.BackColor = System.Drawing.Color.Green;
            this.BGuardarMedioPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardarMedioPago.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardarMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarMedioPago.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarMedioPago.ForeColor = System.Drawing.Color.White;
            this.BGuardarMedioPago.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BGuardarMedioPago.IconColor = System.Drawing.Color.White;
            this.BGuardarMedioPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardarMedioPago.IconSize = 30;
            this.BGuardarMedioPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardarMedioPago.Location = new System.Drawing.Point(159, 214);
            this.BGuardarMedioPago.Name = "BGuardarMedioPago";
            this.BGuardarMedioPago.Size = new System.Drawing.Size(118, 57);
            this.BGuardarMedioPago.TabIndex = 29;
            this.BGuardarMedioPago.Text = "GUARDAR";
            this.BGuardarMedioPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardarMedioPago.UseVisualStyleBackColor = false;
            this.BGuardarMedioPago.Click += new System.EventHandler(this.BGuardarMedioPago_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxFecha);
            this.groupBox1.Controls.Add(this.BCancelar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxComision);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNombreMedioPago);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 197);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Fecha:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.BackColor = System.Drawing.Color.White;
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(15, 106);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(177, 24);
            this.textBoxFecha.TabIndex = 56;
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
            this.BCancelar.Location = new System.Drawing.Point(358, 147);
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
            this.label2.Location = new System.Drawing.Point(212, 85);
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
            this.comboBoxEstado.Location = new System.Drawing.Point(216, 108);
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
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Comision (%):";
            // 
            // textBoxComision
            // 
            this.textBoxComision.BackColor = System.Drawing.Color.White;
            this.textBoxComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComision.Location = new System.Drawing.Point(216, 43);
            this.textBoxComision.Name = "textBoxComision";
            this.textBoxComision.Size = new System.Drawing.Size(177, 24);
            this.textBoxComision.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre medio de pago:";
            // 
            // textBoxNombreMedioPago
            // 
            this.textBoxNombreMedioPago.BackColor = System.Drawing.Color.White;
            this.textBoxNombreMedioPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreMedioPago.Location = new System.Drawing.Point(15, 43);
            this.textBoxNombreMedioPago.Name = "textBoxNombreMedioPago";
            this.textBoxNombreMedioPago.Size = new System.Drawing.Size(177, 24);
            this.textBoxNombreMedioPago.TabIndex = 41;
            // 
            // NuevoMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 281);
            this.Controls.Add(this.BGuardarMedioPago);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NuevoMedioPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo Medio de Pago";
            this.Load += new System.EventHandler(this.NuevoMedioPago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BGuardarMedioPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton BCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNombreMedioPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFecha;
    }
}