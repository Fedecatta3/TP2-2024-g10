using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;

namespace CapaPresentacion
{
    public partial class ListaAlumnos : Form
    {

        private Usuario usuarioActual;

        public ListaAlumnos(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void BVerFicha_Click(object sender, EventArgs e)
        {
            //Modal para ver ficha del alumno
            using (var modal = new FichaAlumno())
            {
                var resultado = modal.ShowDialog();
            }
        }

        private void BNuevoAlumno_Click(object sender, EventArgs e)
        {
            //Modal para agregar nuevo alumno
            using (var modal = new NuevoAlumno())
            {
                var resultado = modal.ShowDialog();
            }
        }

        private void ListaAlumnos_Load(object sender, EventArgs e)
        {
            // Si el rol es de coach ocultamos el botón de nuevo alumno
            if (usuarioActual.id_rol.descripcion == "Coach")
            {
                BNuevoAlumno.Visible = false;
            }
        }
    }
}
