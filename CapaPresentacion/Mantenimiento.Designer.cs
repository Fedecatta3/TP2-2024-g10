
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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.BNuevaMembresia = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.BNuevoMedioPago = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMembresias = new System.Windows.Forms.DataGridView();
            this.dataGridMediosPago = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionMemb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionMedioPago = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembresias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMediosPago)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.BNuevaMembresia);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dataGridMembresias);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEMBRESIAS";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(224, 48);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 24);
            this.textBox8.TabIndex = 40;
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
            this.BNuevaMembresia.Location = new System.Drawing.Point(728, 17);
            this.BNuevaMembresia.Name = "BNuevaMembresia";
            this.BNuevaMembresia.Size = new System.Drawing.Size(125, 55);
            this.BNuevaMembresia.TabIndex = 39;
            this.BNuevaMembresia.Text = "AGREGAR";
            this.BNuevaMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNuevaMembresia.UseVisualStyleBackColor = false;
            this.BNuevaMembresia.Click += new System.EventHandler(this.BNuevaMembresia_Click);
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
            this.iconButton2.Location = new System.Drawing.Point(450, 46);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 26);
            this.iconButton2.TabIndex = 38;
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
            this.iconButton1.Location = new System.Drawing.Point(413, 46);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 26);
            this.iconButton1.TabIndex = 37;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(14, 46);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(204, 26);
            this.comboBox4.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "Buscar por:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.iconButton3);
            this.groupBox3.Controls.Add(this.BNuevoMedioPago);
            this.groupBox3.Controls.Add(this.iconButton4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dataGridMediosPago);
            this.groupBox3.Location = new System.Drawing.Point(12, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(866, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MEDIOS DE PAGO";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(629, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 24);
            this.textBox1.TabIndex = 45;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(816, 100);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(35, 26);
            this.iconButton3.TabIndex = 44;
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
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
            this.BNuevoMedioPago.Location = new System.Drawing.Point(726, 132);
            this.BNuevoMedioPago.Name = "BNuevoMedioPago";
            this.BNuevoMedioPago.Size = new System.Drawing.Size(125, 55);
            this.BNuevoMedioPago.TabIndex = 45;
            this.BNuevoMedioPago.Text = "AGREGAR";
            this.BNuevoMedioPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BNuevoMedioPago.UseVisualStyleBackColor = false;
            this.BNuevoMedioPago.Click += new System.EventHandler(this.BNuevoMedioPago_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.LimeGreen;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 20;
            this.iconButton4.Location = new System.Drawing.Point(779, 100);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(35, 26);
            this.iconButton4.TabIndex = 43;
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(629, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 26);
            this.comboBox1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Buscar por:";
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
            this.fechaCreacionMemb,
            this.costo,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMembresias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMembresias.Location = new System.Drawing.Point(13, 78);
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
            this.dataGridMembresias.Size = new System.Drawing.Size(840, 188);
            this.dataGridMembresias.TabIndex = 41;
            this.dataGridMembresias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMembresias_CellContentClick);
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
            this.dataGridMediosPago.Size = new System.Drawing.Size(607, 168);
            this.dataGridMediosPago.TabIndex = 46;
            this.dataGridMediosPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMediosPago_CellContentClick);
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
            // fechaCreacionMemb
            // 
            this.fechaCreacionMemb.HeaderText = "Fecha de creacion";
            this.fechaCreacionMemb.Name = "fechaCreacionMemb";
            this.fechaCreacionMemb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaCreacionMemb.Width = 180;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // estadoMedioPago
            // 
            this.estadoMedioPago.HeaderText = "Estado";
            this.estadoMedioPago.Name = "estadoMedioPago";
            this.estadoMedioPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha de creacion";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaCreacion.Width = 180;
            // 
            // comision
            // 
            this.comision.HeaderText = "Comision";
            this.comision.Name = "comision";
            this.comision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.comision.Width = 180;
            // 
            // nombreMedioPago
            // 
            this.nombreMedioPago.HeaderText = "Nombre";
            this.nombreMedioPago.Name = "nombreMedioPago";
            this.nombreMedioPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombreMedioPago.Width = 180;
            // 
            // idMedioPago
            // 
            this.idMedioPago.HeaderText = "ID";
            this.idMedioPago.Name = "idMedioPago";
            this.idMedioPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idMedioPago.Visible = false;
            // 
            // accionMedioPago
            // 
            this.accionMedioPago.HeaderText = "Accion";
            this.accionMedioPago.Name = "accionMedioPago";
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
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembresias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMediosPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton BNuevaMembresia;
        private FontAwesome.Sharp.IconButton BNuevoMedioPago;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMembresias;
        private System.Windows.Forms.DataGridView dataGridMediosPago;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionMemb;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn accionMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMedioPago;
    }
}