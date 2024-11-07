using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FichaAlumno : Form
    {
        private int alumno;
        private CN_Alumno objCN_Alumno = new CN_Alumno(); // Capa de negocio para alumnos

        public FichaAlumno(int idAlumno)
        {
            InitializeComponent();
            alumno = idAlumno;
        }

        private void BCobrarCuota_Click(object sender, EventArgs e)
        {
            /*
            //Modal para cobrar cuota del alumno
            using (var modal = new CobrarCuotaAlumno())
            {
                var resultado = modal.ShowDialog();
            }*/
        }

        private void FichaAlumno_Load(object sender, EventArgs e)
        {
            int idMembresia = 0;
            int idUsuario = 0;
            int idPlan = 0;

            List<Alumno> listaAlumnos = objCN_Alumno.Listar();

            foreach (Alumno item in listaAlumnos)
            {
                if (item.id_alumno == alumno)
                {
                    labelNombreCompleto.Text = item.nombre + " " + item.apellido;
                    labelDNI.Text = item.dni;
                    labelFechaNacimiento.Text = item.fecha_nacimiento.ToString("dd/MM/yyyy");
                    labelEmail.Text = item.email;
                    labelSexo.Text = item.sexo;
                    labelTelefono.Text = item.telefono;
                    labelContactoEmergencia.Text = item.contacto_emergencia;
                    labelObservacion.Text = item.observaciones;

                    // Cargar imagen en el PictureBox desde la ruta guardada
                    if (!string.IsNullOrEmpty(item.foto) && File.Exists(item.foto))
                    {
                        pictureBox1.Image = Image.FromFile(item.foto);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la imagen del alumno.", "Error de imagen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        pictureBox1.Image = Properties.Resources.siluetaPerfilPersona;
                    }

                    idMembresia = item.id_membresia;
                    idUsuario = item.id_usuario;
                    idPlan = item.id_plan;
                }
            }

            List<Membresia> listaMembresias = new CN_membresia().Listar();
            List<Usuario> listaUsuarios = new CN_usuario().Listar();
            List<PlanEntrenamiento> listaPlanes = new CN_PlanEntrenamiento().Listar();

            // Utilizar LINQ para encontrar las entidades relacionadas
            var membresia = listaMembresias.FirstOrDefault(m => m.id_membresia == idMembresia);
            var usuario = listaUsuarios.FirstOrDefault(u => u.id_usuario == idUsuario);
            var plan = listaPlanes.FirstOrDefault(p => p.id_plan == idPlan);

            // Agregar la información al DataGridView si se encontraron las coincidencias
            if (membresia != null && usuario != null && plan != null)
            {
                labelTipoMembresia.Text = membresia.nombre;
                labelCoachAcargo.Text = $"{usuario.nombre} {usuario.apellido}";
                labelPlanEntrenamiento.Text = plan.nombre;
            }

        }
    }
}
