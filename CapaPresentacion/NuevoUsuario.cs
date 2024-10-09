using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System.Text.RegularExpressions;

namespace CapaPresentacion
{
    public partial class NuevoUsuario : Form
    {
        public event Action UsuarioRegistrado;
        private int usuarioValor = 0;

        public NuevoUsuario(int usuarioNuevo) //si recibe 1 es nuevo Usuario, si recibe 0 es modificacion de Usuario
        {
            InitializeComponent();
            usuarioValor = usuarioNuevo;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro desea eliminar todos los datos ingresados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                textBoxNombre.Clear();
                textBoxApellido.Clear();
                textBoxDNI.Clear();
                textBoxEmail.Clear();
                textBoxTelefono.Clear();
                textBoxPass.Clear();
                textBoxConfirmarPass.Clear();
                dateTimePicker1.Value = DateTime.Now;
                comboBoxRol.SelectedIndex = 0;
                comboBoxEstado.SelectedIndex = 0;
            }
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            if(usuarioValor == 1)
            {
                verHorario.Visible = false;

                // Cargar ComboBox de Estado
                comboBoxEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
                comboBoxEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "Inactivo" });
                comboBoxEstado.DisplayMember = "Texto";
                comboBoxEstado.ValueMember = "Valor";
                comboBoxEstado.SelectedIndex = 0; // Selecciona el primer elemento por defecto al crear un nuevo usuario

                // Cargar ComboBox de Roles
                List<Rol> listarol = new CN_rol().Listar();
                foreach (Rol item in listarol)
                {
                    comboBoxRol.Items.Add(new opcionCombo() { Valor = item.id_rol, Texto = item.descripcion });
                }
                comboBoxRol.DisplayMember = "Texto";
                comboBoxRol.ValueMember = "Valor";
                comboBoxRol.SelectedIndex = 0; // Selecciona el primer elemento por defecto al crear un nuevo usuario
            }
        }

        private void BGuardarUsuario_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (textBoxPass.Text != textBoxConfirmarPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConfirmarPass.Focus();
                return;
            }

            // Obtener el id del rol seleccionado del ComboBox
            int idRolSeleccionado = Convert.ToInt32(((opcionCombo)comboBoxRol.SelectedItem).Valor);


            Usuario objUsuario = new Usuario()
            {
                id_usuario = Convert.ToInt32(textBoxID.Text),
                id_rol = new Rol() { id_rol = idRolSeleccionado },
                nombre = textBoxNombre.Text,
                email = textBoxEmail.Text,
                telefono = textBoxTelefono.Text,
                dni = textBoxDNI.Text,
                fecha_nacimiento = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                estado = Convert.ToInt32(((opcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false,
                contraseña = textBoxPass.Text,
                apellido = textBoxApellido.Text
            };

            if(objUsuario.id_usuario == 0) //crear un usuario nuevo
            {
                int idUsuarioGenerado = new CN_usuario().Registrar(objUsuario, out mensaje);

                if (idUsuarioGenerado == 0) //mensaje de error 
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    // Mensaje de éxito
                    MessageBox.Show("Usuario ingresado con éxito.");

                    UsuarioRegistrado?.Invoke(); // Dispara el evento de usuario registrado para actualizar el DataGrid
                    this.Close();


                    // Abrir el formulario para agregar horario
                    using (var agregarHorarioForm = new AgregarHorarioUsuario(idUsuarioGenerado))
                    {
                        agregarHorarioForm.ShowDialog();
                    }

                }
            }
            else //editar usuario
            {
                bool resultado = new CN_usuario().Editar(objUsuario, out mensaje);

                if (resultado)
                {
                    // Mensaje de éxito
                    MessageBox.Show("Usuario actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UsuarioRegistrado?.Invoke(); // Dispara el evento de usuario actualizado para refrescar la vista

                    this.Close(); // Cierra el formulario
                }
                else
                {
                    // Mostrar el mensaje de error
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length > 8)
            {
                // limita el campo a 8 digitos
                textBoxDNI.Text = textBoxDNI.Text.Substring(0, 8);
                textBoxDNI.SelectionStart = textBoxDNI.Text.Length; //coloca el cursor al final del texto
            }
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo admite numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //ignora la tecla si no es numero o backspace
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Length < 8)
            {
                errorProvider1.SetError(textBoxPass, "La contraseña debe tener al menos 8 caracteres.");
            }
            else
            {
                errorProvider1.SetError(textBoxPass, "");
            }
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo admite numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //ignora la tecla si no es numero o backspace
            }
        }

        private void textBoxConfirmarPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxConfirmarPass.Text.Length < 8)
            {
                errorProvider2.SetError(textBoxConfirmarPass, "La contraseña debe tener al menos 8 caracteres.");
            }
            else
            {
                errorProvider2.SetError(textBoxConfirmarPass, "");
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignora la tecla si no es letra o espacio
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignora la tecla si no es letra o espacio
            }
        }



        // Carga los datos en el form para realizar la modificacion
        public void CargarDatosUsuario(int idUsuario)
        {
            BCancelar.Visible = false;

            string mensaje = string.Empty;
            Usuario usuario = new CN_usuario().ObtenerUsuarioPorId(idUsuario, out mensaje);

            if (usuario == null)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si el usuario no fue encontrado
            }

            // Cargar los datos en los controles del formulario
            textBoxID.Text = idUsuario.ToString();
            textBoxNombre.Text = usuario.nombre;
            textBoxApellido.Text = usuario.apellido;
            textBoxDNI.Text = usuario.dni;
            textBoxEmail.Text = usuario.email;
            textBoxTelefono.Text = usuario.telefono;
            textBoxPass.Text = usuario.contraseña;
            dateTimePicker1.Value = Convert.ToDateTime(usuario.fecha_nacimiento);

            //carga de comboBox rol
            int valorRol = usuario.id_rol.id_rol - 1;

            List<Rol> listarol = new CN_rol().Listar();
            foreach (Rol item in listarol)
            {
                comboBoxRol.Items.Add(new opcionCombo() { Valor = item.id_rol, Texto = item.descripcion });
            }
            comboBoxRol.DisplayMember = "Texto";
            comboBoxRol.ValueMember = "Valor";
            comboBoxRol.SelectedIndex = valorRol;

            //carga comboBox de Estado
            int valorEstado = usuario.estado ? 0 : 1;

            comboBoxEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
            comboBoxEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "Inactivo" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            comboBoxEstado.SelectedIndex = valorEstado;
        }

        private void verHorario_Click(object sender, EventArgs e)
        {/*
            //Modal para ver horario del usuario
            using (var modal = new AgregarHorarioUsuario())
            {
                var resultado = modal.ShowDialog();
            }*/
        }
    }
}
