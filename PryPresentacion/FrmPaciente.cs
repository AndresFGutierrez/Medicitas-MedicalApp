using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PryPresentacion
{
    public partial class FrmPaciente : MaterialForm
    {
        private ClsPaciente ObjPaciente = null;
        private readonly ClsPacienteLn ObjPacienteLn = new ClsPacienteLn();

        public FrmPaciente()
        {
            InitializeComponent();

            CargarListaPaciente();
        }

        private void CargarListaPaciente()
        {
            ObjPaciente = new ClsPaciente();
            ObjPacienteLn.Index(ref ObjPaciente);
            if (ObjPaciente.MensajeError == null)
            {
                dtvListaMedico.DataSource = ObjPaciente.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjPaciente.MensajeError, "Error Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtvListaMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvListaMedico.Columns[e.ColumnIndex].Name == "Editar")
            {
                ObjPaciente = new ClsPaciente()
                {
                    IDPaciente1 = dtvListaMedico.Rows[e.RowIndex].Cells["IDPaciente"].Value.ToString()
                };
                ObjPacienteLn.Read(ref ObjPaciente);

                txtIdentificacion.Text = ObjPaciente.IDPaciente1;
                txtNombre.Text = ObjPaciente.Nombre1;
                txtDireccion.Text = ObjPaciente.Direccion1;
                txtGenero.Text = ObjPaciente.Genero1;
                txtTelefono.Text = ObjPaciente.Telefono1;
                dtpFechaNacim.Value = ObjPaciente.FechaNacimiento1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ObjPaciente = new ClsPaciente()
            {
                IDPaciente1 = txtIdentificacion.Text,
                Nombre1 = txtNombre.Text,
                Direccion1 = txtDireccion.Text,
                Genero1 = txtGenero.Text,
                Telefono1 = txtTelefono.Text,
                FechaNacimiento1 = dtpFechaNacim.Value
            };
            ObjPacienteLn.Create(ref ObjPaciente);
            if (ObjPaciente.MensajeError == null)
            {
                MessageBox.Show("El paciente: " + ObjPaciente.ValorScalar + " fue agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaPaciente();
            }
            else
            {
                MessageBox.Show(ObjPaciente.MensajeError, "Error Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObjPaciente = new ClsPaciente()
            {
                IDPaciente1 = txtIdentificacion.Text,
                Nombre1 = txtNombre.Text,
                Direccion1 = txtDireccion.Text,
                Genero1 = txtGenero.Text,
                Telefono1 = txtTelefono.Text,
                FechaNacimiento1 = dtpFechaNacim.Value
            };
            ObjPacienteLn.Update(ref ObjPaciente);
            if (ObjPaciente.MensajeError == null)
            {
                MessageBox.Show("El paciente: " + ObjPaciente.ValorScalar + " fue actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaPaciente();
            }
            else
            {
                MessageBox.Show(ObjPaciente.MensajeError, "Error Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar?", "Confirmar eliminacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                ObjPaciente = new ClsPaciente()
                {
                    IDPaciente1 = txtIdentificacion.Text
                };
                ObjPacienteLn.Delete(ref ObjPaciente);
                if (ObjPaciente.MensajeError == null)
                {
                    MessageBox.Show("El paciente: " + ObjPaciente.ValorScalar + " fue ELIMINADO correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaPaciente();
                }
                else
                {
                    MessageBox.Show(ObjPaciente.MensajeError, "Error Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtIdentificacion.Text = "ID Paciente";
            txtNombre.Text = "Nombre Completo";
            txtDireccion.Text = "Direccion";
            txtGenero.Text = "Telefono";
            txtTelefono.Text = "Genero";
            dtpFechaNacim.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                FrmUsuario frmUsuario = new FrmUsuario();
                frmUsuario.Show();
            }
        }

        #region FOCOS_TEXTBOXS_MEDICO

        string defaultIDText = "ID Paciente";
        string defaultNombreText = "Nombre Completo";
        string defaultTelefonoText = "Telefono";
        string defaultGeneroText = "Genero";
        string defaultDireccionText = "Direccion";

        private void txtIdentificacion_Enter(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == defaultIDText)
            {
                txtIdentificacion.Text = "";
                txtIdentificacion.ForeColor = Color.Black;
            }
        }

        private void txtIdentificacion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                txtIdentificacion.Text = defaultIDText;
                txtIdentificacion.ForeColor = Color.Silver;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == defaultNombreText)
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = defaultNombreText;
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == defaultDireccionText)
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                txtDireccion.Text = defaultDireccionText;
                txtDireccion.ForeColor = Color.Silver;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == defaultTelefonoText)
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = defaultTelefonoText;
                txtTelefono.ForeColor = Color.Silver;
            }
        }

        private void txtGenero_Enter(object sender, EventArgs e)
        {
            if (txtGenero.Text == defaultGeneroText)
            {
                txtGenero.Text = "";
                txtGenero.ForeColor = Color.Black;
            }
        }

        private void txtGenero_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                txtGenero.Text = defaultGeneroText;
                txtGenero.ForeColor = Color.Silver;
            }
        }


        #endregion

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            FrmHistorialMedico frmHistorialMedico = new FrmHistorialMedico();
            frmHistorialMedico.Show();
            this.Hide();
        }

        
    }
}
