
namespace CapaPresentacion
{
    partial class NuevaMembresia
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.BGuardarMembresia = new FontAwesome.Sharp.IconButton();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.BCancelar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombreMembresia = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.textBoxDuracion);
            this.groupBox1.Controls.Add(this.BGuardarMembresia);
            this.groupBox1.Controls.Add(this.textBoxFecha);
            this.groupBox1.Controls.Add(this.BCancelar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCosto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNombreMembresia);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.White;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(198, 175);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(24, 24);
            this.textBoxID.TabIndex = 59;
            this.textBoxID.Text = "0";
            this.textBoxID.Visible = false;
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.BackColor = System.Drawing.Color.White;
            this.textBoxDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracion.Location = new System.Drawing.Point(216, 112);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(177, 24);
            this.textBoxDuracion.TabIndex = 60;
            this.textBoxDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDuracion_KeyPress);
            // 
            // BGuardarMembresia
            // 
            this.BGuardarMembresia.BackColor = System.Drawing.Color.Green;
            this.BGuardarMembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardarMembresia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardarMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarMembresia.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarMembresia.ForeColor = System.Drawing.Color.White;
            this.BGuardarMembresia.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BGuardarMembresia.IconColor = System.Drawing.Color.White;
            this.BGuardarMembresia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BGuardarMembresia.IconSize = 30;
            this.BGuardarMembresia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardarMembresia.Location = new System.Drawing.Point(275, 164);
            this.BGuardarMembresia.Name = "BGuardarMembresia";
            this.BGuardarMembresia.Size = new System.Drawing.Size(118, 35);
            this.BGuardarMembresia.TabIndex = 27;
            this.BGuardarMembresia.Text = "GUARDAR";
            this.BGuardarMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardarMembresia.UseVisualStyleBackColor = false;
            this.BGuardarMembresia.Click += new System.EventHandler(this.BGuardarUsuario_Click);
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.BackColor = System.Drawing.Color.White;
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(15, 112);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(177, 24);
            this.textBoxFecha.TabIndex = 59;
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
            this.BCancelar.Location = new System.Drawing.Point(234, 164);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(35, 35);
            this.BCancelar.TabIndex = 28;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(212, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Duracion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Fecha creacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 152);
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
            this.comboBoxEstado.Location = new System.Drawing.Point(15, 175);
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
            this.label1.Text = "Costo:";
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.BackColor = System.Drawing.Color.White;
            this.textBoxCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCosto.Location = new System.Drawing.Point(216, 43);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(177, 24);
            this.textBoxCosto.TabIndex = 43;
            this.textBoxCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCosto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre membresia:";
            // 
            // textBoxNombreMembresia
            // 
            this.textBoxNombreMembresia.BackColor = System.Drawing.Color.White;
            this.textBoxNombreMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreMembresia.Location = new System.Drawing.Point(15, 43);
            this.textBoxNombreMembresia.Name = "textBoxNombreMembresia";
            this.textBoxNombreMembresia.Size = new System.Drawing.Size(177, 24);
            this.textBoxNombreMembresia.TabIndex = 41;
            // 
            // NuevaMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 245);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NuevaMembresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membresia";
            this.Load += new System.EventHandler(this.NuevaMembresia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombreMembresia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton BCancelar;
        private FontAwesome.Sharp.IconButton BGuardarMembresia;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.TextBox textBoxID;
    }
}