using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PryPresentacion
{
    public partial class FrmRegistro : MaterialForm
    {

        private ClsUsuario objUsuario = null;
        private readonly ClsUsuarioLn objUsuarioLn = new ClsUsuarioLn();

        public FrmRegistro()
        {
            InitializeComponent();
        }



        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            // Validaciones simples
            if (string.IsNullOrWhiteSpace(TxtRegistroEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtRegistroContraseña.Text) ||
                string.IsNullOrWhiteSpace(TxtRegistroConfirmar.Text) ||
                CbRegistroCargo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que las contraseñas coincidan
            if (TxtRegistroContraseña.Text != TxtRegistroConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un nuevo objeto usuario
            objUsuario = new ClsUsuario()
            {
                Email = TxtRegistroEmail.Text,
                Contrasena = TxtRegistroContraseña.Text,
                Rol = CbRegistroCargo.Text
            };

            // Llamar al método de registro en la lógica de negocio
            objUsuarioLn.Create(ref objUsuario);

            // Manejar la respuesta del registro
            if (objUsuario.MensajeError == null)
            {
                MessageBox.Show("Registro exitoso. Ahora puede iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmUsuario frmUsuario = new FrmUsuario();
                frmUsuario.Show(); // O usar ShowDialog() si prefieres que sea modal

                this.Close(); // Cerrar el formulario de registro
            }
            else
            {
                MessageBox.Show("Error durante el registro: " + objUsuario.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #region FOCOS_TEXTS_BOXS
        // Texto por defecto (Placeholder)
        string defaultEmailText = "Email";
        string defaultPasswordText = "Contraseña";
        string defaultConfirmText = "Confirme Contraseña";
        string defaultCargoText = "Cargo";

        // Evento para Email
        private void TxtRegistroEmail_Enter(object sender, EventArgs e)
        {
            if (TxtRegistroEmail.Text == defaultEmailText)
            {
                TxtRegistroEmail.Text = "";
                TxtRegistroEmail.ForeColor = Color.Black;
            }
        }

        private void TxtRegistroEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtRegistroEmail.Text))
            {
                TxtRegistroEmail.Text = defaultEmailText;
                TxtRegistroEmail.ForeColor = Color.Silver;
            }
        }

        // Evento para Contraseña
        private void TxtRegistroContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtRegistroContraseña.Text == defaultPasswordText)
            {
                TxtRegistroContraseña.Text = "";
                TxtRegistroContraseña.ForeColor = Color.Black;
                TxtRegistroContraseña.UseSystemPasswordChar = true; // Esconde la contraseña
            }
        }

        private void TxtRegistroContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtRegistroContraseña.Text))
            {
                TxtRegistroContraseña.UseSystemPasswordChar = false; // Muestra texto de nuevo
                TxtRegistroContraseña.Text = defaultPasswordText;
                TxtRegistroContraseña.ForeColor = Color.Silver;
            }
        }

        // Evento para Confirmar Contraseña
        private void TxtRegistroConfirmar_Enter(object sender, EventArgs e)
        {
            if (TxtRegistroConfirmar.Text == defaultConfirmText)
            {
                TxtRegistroConfirmar.Text = "";
                TxtRegistroConfirmar.ForeColor = Color.Black;
                TxtRegistroConfirmar.UseSystemPasswordChar = true; // Esconde la confirmación
            }
        }

        private void TxtRegistroConfirmar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtRegistroConfirmar.Text))
            {
                TxtRegistroConfirmar.UseSystemPasswordChar = false; // Muestra texto de nuevo
                TxtRegistroConfirmar.Text = defaultConfirmText;
                TxtRegistroConfirmar.ForeColor = Color.Silver;
            }
        }

        // Evento para Cargo (ComboBox)
        private void CbRegistroCargo_Enter(object sender, EventArgs e)
        {
            if (CbRegistroCargo.Text == defaultCargoText)
            {
                CbRegistroCargo.Text = "";
                CbRegistroCargo.ForeColor = Color.Black;
            }
        }

        private void CbRegistroCargo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CbRegistroCargo.Text))
            {
                CbRegistroCargo.Text = defaultCargoText;
                CbRegistroCargo.ForeColor = Color.Silver;
            }
        }

        #endregion
    }
}
