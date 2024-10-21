using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //Modal para cobrar cuota del alumno
            using (var modal = new CobrarCuotaAlumno())
            {
                var resultado = modal.ShowDialog();
            }
        }

        private void FichaAlumno_Load(object sender, EventArgs e)
        {
            List<Alumno> listaAlumnos = objCN_Alumno.Listar();

            foreach (Alumno item in listaAlumnos)
            {
                if (item.id_alumno == alumno)
                {
                    labelNombreCompleto.Text = item.nombre + " " + item.apellido;
                    labelDNI.Text = item.dni;
                    labelFechaNacimiento.Text = item.fecha_nacimiento.ToString();
                    labelEmail.Text = item.email;
                    labelSexo.Text = item.sexo;
                    labelTelefono.Text = item.telefono;
                    labelContactoEmergencia.Text = item.contacto_emergencia;
                    labelObservacion.Text = item.observaciones;
                }
            }
        }
    }
}
