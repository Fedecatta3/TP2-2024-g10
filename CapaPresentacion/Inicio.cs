using System;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            Principal form = new Principal(); //crea una instancia del formulario principal
            
            this.Hide(); //el formulario del login(inicio) se oculta una vez ingresado

            form.ShowDialog(); //muestra el formulario principal como diálogo modal

            textBoxEmail.Text = "";
            textBoxPass.Text = "";

            //this.Close(); //cuando el formulario principal se cierra tambien se cierra el programa

            this.Show(); //muestra de nuevo el formulario de inicio cuando el principal se cierra
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
