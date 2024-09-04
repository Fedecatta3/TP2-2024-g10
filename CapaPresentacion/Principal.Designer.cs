
namespace CapaPresentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenimiento = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuMembresias = new FontAwesome.Sharp.IconMenuItem();
            this.menuAlumnos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuNuevoAlumno = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuListaAlumnos = new FontAwesome.Sharp.IconMenuItem();
            this.menuPlanes = new FontAwesome.Sharp.IconMenuItem();
            this.menuPagos = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.menuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOpciones
            // 
            this.menuOpciones.AutoSize = false;
            this.menuOpciones.BackColor = System.Drawing.Color.OrangeRed;
            this.menuOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuOpciones.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuMantenimiento,
            this.menuAlumnos,
            this.menuPlanes,
            this.menuPagos,
            this.menuReportes,
            this.menuAcercaDe});
            this.menuOpciones.Location = new System.Drawing.Point(0, 93);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuOpciones.Size = new System.Drawing.Size(210, 507);
            this.menuOpciones.TabIndex = 0;
            this.menuOpciones.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.BackColor = System.Drawing.Color.OrangeRed;
            this.menuUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(220, 54);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuMantenimiento
            // 
            this.menuMantenimiento.AutoSize = false;
            this.menuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuMembresias});
            this.menuMantenimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMantenimiento.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.menuMantenimiento.IconColor = System.Drawing.Color.Black;
            this.menuMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenimiento.IconSize = 50;
            this.menuMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuMantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenimiento.Name = "menuMantenimiento";
            this.menuMantenimiento.Size = new System.Drawing.Size(220, 54);
            this.menuMantenimiento.Text = "Mantenimiento";
            // 
            // subMenuMembresias
            // 
            this.subMenuMembresias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuMembresias.IconColor = System.Drawing.Color.Black;
            this.subMenuMembresias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuMembresias.Name = "subMenuMembresias";
            this.subMenuMembresias.Size = new System.Drawing.Size(188, 30);
            this.subMenuMembresias.Text = "Membresias";
            // 
            // menuAlumnos
            // 
            this.menuAlumnos.AutoSize = false;
            this.menuAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuNuevoAlumno,
            this.subMenuListaAlumnos});
            this.menuAlumnos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAlumnos.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuAlumnos.IconColor = System.Drawing.Color.Black;
            this.menuAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAlumnos.IconSize = 50;
            this.menuAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuAlumnos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAlumnos.Name = "menuAlumnos";
            this.menuAlumnos.Size = new System.Drawing.Size(220, 54);
            this.menuAlumnos.Text = "Alumnos";
            // 
            // subMenuNuevoAlumno
            // 
            this.subMenuNuevoAlumno.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuNuevoAlumno.IconColor = System.Drawing.Color.Black;
            this.subMenuNuevoAlumno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuNuevoAlumno.Name = "subMenuNuevoAlumno";
            this.subMenuNuevoAlumno.Size = new System.Drawing.Size(227, 30);
            this.subMenuNuevoAlumno.Text = "Nuevo alumno";
            this.subMenuNuevoAlumno.Click += new System.EventHandler(this.subMenuNuevoAlumno_Click);
            // 
            // subMenuListaAlumnos
            // 
            this.subMenuListaAlumnos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuListaAlumnos.IconColor = System.Drawing.Color.Black;
            this.subMenuListaAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuListaAlumnos.Name = "subMenuListaAlumnos";
            this.subMenuListaAlumnos.Size = new System.Drawing.Size(227, 30);
            this.subMenuListaAlumnos.Text = "Lista de alumnos";
            this.subMenuListaAlumnos.Click += new System.EventHandler(this.subMenuListaAlumnos_Click);
            // 
            // menuPlanes
            // 
            this.menuPlanes.AutoSize = false;
            this.menuPlanes.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPlanes.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.menuPlanes.IconColor = System.Drawing.Color.Black;
            this.menuPlanes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuPlanes.IconSize = 50;
            this.menuPlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuPlanes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPlanes.Name = "menuPlanes";
            this.menuPlanes.Size = new System.Drawing.Size(220, 54);
            this.menuPlanes.Text = "Planes";
            // 
            // menuPagos
            // 
            this.menuPagos.AutoSize = false;
            this.menuPagos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPagos.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.menuPagos.IconColor = System.Drawing.Color.Black;
            this.menuPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuPagos.IconSize = 50;
            this.menuPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuPagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPagos.Name = "menuPagos";
            this.menuPagos.Size = new System.Drawing.Size(220, 54);
            this.menuPagos.Text = "Pagos";
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(220, 54);
            this.menuReportes.Text = "Reportes";
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.AutoSize = false;
            this.menuAcercaDe.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercaDe.IconSize = 50;
            this.menuAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(220, 54);
            this.menuAcercaDe.Text = "Acerca de";
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Black;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1000, 93);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.LightGray;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(210, 93);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(790, 507);
            this.contenedor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(703, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(764, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(703, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rol del usuario";
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.BackColor = System.Drawing.Color.Black;
            this.BCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.BCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.BCerrarSesion.IconColor = System.Drawing.Color.Red;
            this.BCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCerrarSesion.IconSize = 50;
            this.BCerrarSesion.Location = new System.Drawing.Point(933, 17);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(67, 62);
            this.BCerrarSesion.TabIndex = 5;
            this.BCerrarSesion.UseVisualStyleBackColor = false;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconButton1.IconColor = System.Drawing.Color.OrangeRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(210, 93);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "GYMMASTER";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCerrarSesion);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menuOpciones);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuOpciones;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantenimiento;
        private FontAwesome.Sharp.IconMenuItem menuAlumnos;
        private FontAwesome.Sharp.IconMenuItem menuPlanes;
        private FontAwesome.Sharp.IconMenuItem menuPagos;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconMenuItem subMenuMembresias;
        private FontAwesome.Sharp.IconMenuItem subMenuNuevoAlumno;
        private FontAwesome.Sharp.IconMenuItem subMenuListaAlumnos;
    }
}

