﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        //variables que sirven para almacenar el menu y formulario que se esta visualizando
        private static IconMenuItem MenuActivo = null;
        private static IconMenuItem SubMenuActivo = null;
        private static Form formularioActivo = null;

        public Principal()
        {
            InitializeComponent();
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(respuesta == DialogResult.Yes){
                this.Close();
            }
        }

        //metodo para abrir los distintos formularios
        public void AbrirFormulario(IconMenuItem menu, IconMenuItem subMenu, Form formulario) //recibe el menu que fue clickeado y el formulario que se desea abrir
        {
            //si hay un menu/subMenu activo se vuelve a su color normal
            if (MenuActivo != null){
                MenuActivo.BackColor = Color.OrangeRed;
            }
            if(SubMenuActivo != null){
                SubMenuActivo.BackColor = Color.White;
            }


            //nuevo menu a visualizar
            menu.BackColor = Color.White; //cambia color del menu para identificar que esta siendo clikeado
            MenuActivo = menu; //pasa a ser el menu activo


            //si existe un subMenu
            if(subMenu != null)
            {
                subMenu.BackColor = Color.Silver; //cambia color del sub menu para identificar que esta siendo clikeado
                SubMenuActivo = subMenu;
            }


            /*visualizar formulario del menu seleccionado*/

            if (formularioActivo != null){
                formularioActivo.Close(); //el formulario que se encuentra activo se cierra
            }

            formularioActivo = formulario; //formulario que se desea visualizar

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill; //se adapta a todo el espacio del contenedor
            formulario.BackColor = Color.White; //color de fondo del formulario

            contenedor.Controls.Add(formulario); //agrega el formulario al panel de la pagina principal
            formulario.Show();
        }

        private void subMenuNuevoAlumno_Click(object sender, EventArgs e){
            AbrirFormulario(menuAlumnos, (IconMenuItem)sender, new NuevoAlumno());
        }

        private void subMenuListaAlumnos_Click(object sender, EventArgs e){
            AbrirFormulario(menuAlumnos, (IconMenuItem)sender, new ListaAlumnos());
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, null, new Usuarios());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //textBoxFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void menuMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, null, new Mantenimiento());
        }

        private void nuevoPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void subMenuVerPlanes_Click(object sender, EventArgs e)
        {

        }

        private void menuPagos_Click(object sender, EventArgs e)
        {

        }

        private void menuReportes_Click(object sender, EventArgs e)
        {

        }

        private void menuBackUp_Click(object sender, EventArgs e)
        {

        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {

        }
    }
}