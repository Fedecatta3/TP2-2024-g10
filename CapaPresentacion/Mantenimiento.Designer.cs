
namespace CapaPresentacion
{
    partial class Mantenimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BNuevaMembresia = new FontAwesome.Sharp.IconButton();
            this.dataGridMembresias = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BNuevoMedioPago = new FontAwesome.Sharp.IconButton();
            this.dataGridMediosPago = new System.Windows.Forms.DataGridView();
            this.accionMedioPago = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionMemb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembresias)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMediosPago)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BNuevaMembresia);
            this.groupBox1.Controls.Add(this.dataGridMembresias);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEMBRESIAS";
            // 
            // BNuevaMembresia
            // 
            this.BNuevaMembresia.BackColor = System.Drawing.Color.OrangeRed;
            this.BNuevaMembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNuevaMembresia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BNuevaMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevaMembresia.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevaMembresia.ForeColor = System.Drawing.Color.White;
            this.BNuevaMembresia.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BNuevaMembresia.IconColor = System.Drawing.Color.White;
            this.BNuevaMembresia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BNuevaMembresia.IconSize = 35;
            this.BNuevaMembresia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BNuevaMembresia.Location = new System.Drawing.Point(735, 20);
            this.BNuevaMembresia.Name = "BNuevaMembresia";
            this.BNuevaMembresia.Size = new System.Drawing.Size(125, 55);
            this.BNuevaMembresia.TabIndex = 39;
            this.BNuevaMembresia.Text = "AGREGAR";
            this.BNuevaMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNuevaMembresia.UseVisualStyleBackColor = false;
            this.BNuevaMembresia.Click += new System.EventHandler(this.BNuevaMembresia_Click);
            // 
            // dataGridMembresias
            // 
            this.dataGridMembresias.AllowUserToAddRows = false;
            this.dataGridMembresias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMembresias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMembresias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMembresias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion,
            this.idMembresia,
            this.nombreMembresia,
            this.duracion,
            this.costo,
            this.fechaCreacionMemb,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMembresias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMembresias.Location = new System.Drawing.Point(13, 20);
            this.dataGridMembresias.MultiSelect = false;
            this.dataGridMembresias.Name = "dataGridMembresias";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMembresias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMembresias.RowTemplate.Height = 30;
            this.dataGridMembresias.Size = new System.Drawing.Size(709, 203);
            this.dataGridMembresias.TabIndex = 41;
            this.dataGridMembresias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMembresias_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BNuevoMedioPago);
            this.groupBox3.Controls.Add(this.dataGridMediosPago);
            this.groupBox3.Location = new System.Drawing.Point(12, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(866, 231);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MEDIOS DE PAGO";
            // 
            // BNuevoMedioPago
            // 
            this.BNuevoMedioPago.BackColor = System.Drawing.Color.OrangeRed;
            this.BNuevoMedioPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNuevoMedioPago.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BNuevoMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevoMedioPago.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoMedioPago.ForeColor = System.Drawing.Color.White;
            this.BNuevoMedioPago.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BNuevoMedioPago.IconColor = System.Drawing.Color.White;
            this.BNuevoMedioPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BNuevoMedioPago.IconSize = 35;
            this.BNuevoMedioPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BNuevoMedioPago.Location = new System.Drawing.Point(735, 19);
            this.BNuevoMedioPago.Name = "BNuevoMedioPago";
            this.BNuevoMedioPago.Size = new System.Drawing.Size(125, 55);
            this.BNuevoMedioPago.TabIndex = 45;
            this.BNuevoMedioPago.Text = "AGREGAR";
            this.BNuevoMedioPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNuevoMedioPago.UseVisualStyleBackColor = false;
            this.BNuevoMedioPago.Click += new System.EventHandler(this.BNuevoMedioPago_Click);
            // 
            // dataGridMediosPago
            // 
            this.dataGridMediosPago.AllowUserToAddRows = false;
            this.dataGridMediosPago.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMediosPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMediosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMediosPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accionMedioPago,
            this.idMedioPago,
            this.nombreMedioPago,
            this.comision,
            this.fechaCreacion,
            this.estadoMedioPago});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMediosPago.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridMediosPago.Location = new System.Drawing.Point(13, 19);
            this.dataGridMediosPago.MultiSelect = false;
            this.dataGridMediosPago.Name = "dataGridMediosPago";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMediosPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridMediosPago.RowTemplate.Height = 30;
            this.dataGridMediosPago.Size = new System.Drawing.Size(709, 202);
            this.dataGridMediosPago.TabIndex = 46;
            this.dataGridMediosPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMediosPago_CellContentClick);
            // 
            // accionMedioPago
            // 
            this.accionMedioPago.HeaderText = "Accion";
            this.accionMedioPago.Name = "accionMedioPago";
            // 
            // idMedioPago
            // 
            this.idMedioPago.HeaderText = "ID";
            this.idMedioPago.Name = "idMedioPago";
            this.idMedioPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idMedioPago.Visible = false;
            // 
            // nombreMedioPago
            // 
            this.nombreMedioPago.HeaderText = "Nombre";
            this.nombreMedioPago.Name = "nombreMedioPago";
            this.nombreMedioPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombreMedioPago.Width = 180;
            // 
            // comision
            // 
            this.comision.HeaderText = "Comision";
            this.comision.Name = "comision";
            this.comision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.comision.Width = 180;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha de creacion";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaCreacion.Width = 180;
            // 
            // estadoMedioPago
            // 
            this.estadoMedioPago.HeaderText = "Estado";
            this.estadoMedioPago.Name = "estadoMedioPago";
            this.estadoMedioPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            // 
            // idMembresia
            // 
            this.idMembresia.HeaderText = "ID";
            this.idMembresia.Name = "idMembresia";
            this.idMembresia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idMembresia.Visible = false;
            // 
            // nombreMembresia
            // 
            this.nombreMembresia.HeaderText = "Nombre";
            this.nombreMembresia.Name = "nombreMembresia";
            this.nombreMembresia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombreMembresia.Width = 180;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duracion";
            this.duracion.Name = "duracion";
            this.duracion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.duracion.Width = 180;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaCreacionMemb
            // 
            this.fechaCreacionMemb.HeaderText = "Fecha de creacion";
            this.fechaCreacionMemb.Name = "fechaCreacionMemb";
            this.fechaCreacionMemb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaCreacionMemb.Width = 180;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 507);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mantenimiento";
            this.Text = "ListaUsuarios";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembresias)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMediosPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton BNuevaMembresia;
        private FontAwesome.Sharp.IconButton BNuevoMedioPago;
        private System.Windows.Forms.DataGridView dataGridMembresias;
        private System.Windows.Forms.DataGridView dataGridMediosPago;
        private System.Windows.Forms.DataGridViewButtonColumn accionMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMedioPago;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionMemb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}