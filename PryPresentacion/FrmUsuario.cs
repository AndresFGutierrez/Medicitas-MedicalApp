using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PryPresentacion
{
    public partial class FrmUsuario : MaterialForm
    {
        private ClsUsuario objUsuario = null;
        private readonly ClsUsuarioLn objUsuarioLn = new ClsUsuarioLn();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objUsuario = new ClsUsuario()
            {
                Email = txtEmail.Text,
                Contrasena = txtContrasena.Text,
                Rol = cbCargo.Text // Asegúrate de que este valor está capturando correctamente el cargo
            };

            // Llamamos al método de validación
            objUsuarioLn.Validar(ref objUsuario);

            // Si no hay errores de base de datos
            if (objUsuario.MensajeError == null)
            {
                // Si se obtuvieron resultados en la validación (usuario y contraseña correctos)
                if (objUsuario.DtResultados.Rows.Count > 0)
                {
                    // Verifica el rol del usuario
                    string rolUsuario = objUsuario.Rol; // Verificamos el rol del usuario

                    MessageBox.Show("Bienvenido al servicio de MEDICITAS " + objUsuario.Email, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Carga el formulario correspondiente según el rol
                    if (rolUsuario.Equals("Medico", StringComparison.OrdinalIgnoreCase)) // Si el rol es médico
                    {
                        FrmMedico frmMedico = new FrmMedico();
                        frmMedico.Show(); // Mostrar el formulario de médico
                        this.Hide(); // Ocultamos el formulario actual
                    }
                    else if (rolUsuario.Equals("Paciente", StringComparison.OrdinalIgnoreCase)) // Si el rol es paciente
                    {
                        FrmPaciente frmPaciente = new FrmPaciente();
                        frmPaciente.Show(); // Mostrar el formulario de paciente
                        this.Hide(); // Ocultamos el formulario actual
                    }
                    else
                    {
                        MessageBox.Show("El rol no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error DB: " + objUsuario.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #region FOCOS_PARA_TEXTBOXS
        string defaultPasswordText = "Contraseña:";
        string defaultCargoText = "Cargo";

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email:")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black; // Cambia el color del texto a negro
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email:";
                txtEmail.ForeColor = Color.Silver; // Cambia el color del texto a gris para indicar que es un placeholder
            }
        }


        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == defaultPasswordText)
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true; // Esconde la contraseña
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.UseSystemPasswordChar = false; // Muestra texto de nuevo
                txtContrasena.Text = defaultPasswordText;
                txtContrasena.ForeColor = Color.Silver;
            }
        }

        private void cbCargo_Enter(object sender, EventArgs e)
        {
            if (cbCargo.Text == defaultCargoText)
            {
                cbCargo.Text = "";
                cbCargo.ForeColor = Color.Black;
            }
        }

        private void cbCargo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCargo.Text))
            {
                cbCargo.Text = defaultCargoText;
                cbCargo.ForeColor = Color.Silver;
            }
        }

        #endregion

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();

            // Mostrar el formulario de registro
            frmRegistro.Show();

            // Cerrar el formulario de login actual
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
