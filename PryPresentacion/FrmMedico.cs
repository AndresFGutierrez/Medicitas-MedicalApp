using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PryPresentacion
{
    public partial class FrmMedico : MaterialForm
    {
        private ClsMedico ObjMedico = null;
        private readonly ClsMedicoLn ObjMedicoLn = new ClsMedicoLn();

        public FrmMedico()
        {
            InitializeComponent();
            CargarListaMedicos();
        }

        private void CargarListaMedicos()
        {
            ObjMedico = new ClsMedico();
            ObjMedicoLn.Index(ref ObjMedico);
            if (ObjMedico.MensajeError == null)
            {
                dgvMedico.DataSource = ObjMedico.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjMedico.MensajeError, "Error Medicos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSalirM_Click(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TimeSpan horarioAtencion;
            string horaTexto = txtHora.Text;

            // Intentar convertir el texto de la hora a TimeSpan
            if (!TimeSpan.TryParse(horaTexto, out horarioAtencion))
            {
                // Si la conversión falla, intenta convertir usando DateTime
                if (DateTime.TryParse(horaTexto, out DateTime horaConvertida))
                {
                    horarioAtencion = horaConvertida.TimeOfDay;
                }
                else
                {
                    // Si todo falla, establecer un valor predeterminado
                    horarioAtencion = TimeSpan.Zero; // o cualquier otro valor que consideres
                }
            }

            ObjMedico = new ClsMedico()
            {
                IDMedico1 = txtIDMedico.Text,
                Nombre1 = txtNombreMedico.Text,
                Especialidad1 = txtEspecialidad.Text,
                Telefono1 = txtTelefonoM.Text,
                Genero1 = txtGeneroM.Text,
                FechaNacimiento1 = dtpFechaN.Value,
                HorarioAtencion1 = horarioAtencion
            };

            ObjMedicoLn.Create(ref ObjMedico);
            if (ObjMedico.MensajeError == null)
            {
                MessageBox.Show("El médico: " + ObjMedico.ValorScalar + " fue agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaMedicos();
            }
            else
            {
                MessageBox.Show(ObjMedico.MensajeError, "Error Medicos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Limpiar();
        }

        private void Limpiar()
        {
            // Limpiar los controles
            txtIDMedico.Text = "";
            txtNombreMedico.Text = "";
            txtEspecialidad.Text = "";
            txtTelefonoM.Text = "";
            txtGeneroM.Text = "";
            dtpFechaN.Value = DateTime.Now;
            txtHora.Text = "00:00 a.m"; // o "00:00" dependiendo del formato que desees
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TimeSpan horarioAtencion;
            string horaTexto = txtHora.Text;

            // Intentar convertir el texto de la hora a TimeSpan
            if (!TimeSpan.TryParse(horaTexto, out horarioAtencion))
            {
                // Si la conversión falla, puedes establecer un valor predeterminado, como TimeSpan.Zero
                // O puedes intentar convertir con un formato específico
                if (DateTime.TryParse(horaTexto, out DateTime horaConvertida))
                {
                    horarioAtencion = horaConvertida.TimeOfDay;
                }
                else
                {
                    // Si todo falla, establecer un valor predeterminado
                    horarioAtencion = TimeSpan.Zero; // o cualquier otro valor que consideres
                }
            }

            ObjMedico = new ClsMedico()
            {
                IDMedico1 = txtIDMedico.Text,
                Nombre1 = txtNombreMedico.Text,
                Especialidad1 = txtEspecialidad.Text,
                Telefono1 = txtTelefonoM.Text,
                Genero1 = txtGeneroM.Text,
                FechaNacimiento1 = dtpFechaN.Value,
                HorarioAtencion1 = horarioAtencion
            };

            ObjMedicoLn.Update(ref ObjMedico);
            if (ObjMedico.MensajeError == null)
            {
                MessageBox.Show("El médico: " + ObjMedico.ValorScalar + " fue actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaMedicos();
            }
            else
            {
                MessageBox.Show(ObjMedico.MensajeError, "Error Patrones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar?", "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                ObjMedico = new ClsMedico()
                {
                    IDMedico1 = txtIDMedico.Text,
                };
                ObjMedicoLn.Delete(ref ObjMedico);
                if (ObjMedico.MensajeError == null)
                {
                    MessageBox.Show("El médico: " + ObjMedico.ValorScalar + " fue eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaMedicos();
                }
                else
                {
                    MessageBox.Show(ObjMedico.MensajeError, "Error Patrones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Limpiar();
            }
        }

        private void dgvMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMedico.Columns[e.ColumnIndex].Name == "Editar")
            {
                ObjMedico = new ClsMedico()
                {
                    IDMedico1 = dgvMedico.Rows[e.RowIndex].Cells["IDMedico"].Value.ToString()
                };
                ObjMedicoLn.Read(ref ObjMedico);

                // Asignar los valores a los controles
                txtIDMedico.Text = ObjMedico.IDMedico1;
                txtIDMedico.ForeColor = Color.Black;
                txtNombreMedico.Text = ObjMedico.Nombre1;
                txtNombreMedico.ForeColor = Color.Black;
                txtEspecialidad.Text = ObjMedico.Especialidad1;
                txtEspecialidad.ForeColor = Color.Black;
                txtTelefonoM.Text = ObjMedico.Telefono1;
                txtTelefonoM.ForeColor = Color.Black;
                txtGeneroM.Text = ObjMedico.Genero1;
                txtGeneroM.ForeColor = Color.Black;
                dtpFechaN.Value = ObjMedico.FechaNacimiento1;

                // Convertir el TimeSpan a string en formato corto de hora
                txtHora.Text = DateTime.Today.Add(ObjMedico.HorarioAtencion1).ToShortTimeString();
            }
        }

        #region FOCOS_TEXTBOXS_MEDICO

        string defaultIDText = "ID Medico";
        string defaultNombreText = "Nombre Completo";
        string defaultTelefonoText = "Telefono";
        string defaultGeneroText = "Genero";
        string defaultEspecialidadText = "Especialidad";

        private void txtIDMedico_Enter(object sender, EventArgs e)
        {
            if (txtIDMedico.Text == defaultIDText)
            {
                txtIDMedico.Text = "";
                txtIDMedico.ForeColor = Color.Black;
            }
        }

        private void txtIDMedico_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDMedico.Text))
            {
                txtIDMedico.Text = defaultIDText;
                txtIDMedico.ForeColor = Color.Silver;
            }
        }

        private void txtNombreMedico_Enter(object sender, EventArgs e)
        {
            if (txtNombreMedico.Text == defaultNombreText)
            {
                txtNombreMedico.Text = "";
                txtNombreMedico.ForeColor = Color.Black;
            }
        }

        private void txtNombreMedico_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMedico.Text))
            {
                txtNombreMedico.Text = defaultNombreText;
                txtNombreMedico.ForeColor = Color.Silver;
            }
        }

        private void txtEspecialidad_Enter(object sender, EventArgs e)
        {
            if (txtEspecialidad.Text == defaultEspecialidadText)
            {
                txtEspecialidad.Text = "";
                txtEspecialidad.ForeColor = Color.Black;
            }
        }

        private void txtEspecialidad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                txtEspecialidad.Text = defaultEspecialidadText;
                txtEspecialidad.ForeColor = Color.Silver;
            }
        }

        private void txtTelefonoM_Enter(object sender, EventArgs e)
        {
            if (txtTelefonoM.Text == defaultTelefonoText)
            {
                txtTelefonoM.Text = "";
                txtTelefonoM.ForeColor = Color.Black;
            }
        }

        private void txtTelefonoM_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefonoM.Text))
            {
                txtTelefonoM.Text = defaultTelefonoText;
                txtTelefonoM.ForeColor = Color.Silver;
            }
        }

        private void txtGeneroM_Enter(object sender, EventArgs e)
        {
            if (txtGeneroM.Text == defaultGeneroText)
            {
                txtGeneroM.Text = "";
                txtGeneroM.ForeColor = Color.Black;
            }
        }

        private void txtGeneroM_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGeneroM.Text))
            {
                txtGeneroM.Text = defaultGeneroText;
                txtGeneroM.ForeColor = Color.Silver;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHistorialMedico frmHistorialMedico = new FrmHistorialMedico();
            frmHistorialMedico.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCitas frmcitas = new FrmCitas();
            frmcitas.Show();
            this.Hide();
        }
    }
}
