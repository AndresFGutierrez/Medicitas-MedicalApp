using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace PryPresentacion
{
    public partial class FrmHistorialMedico : MaterialForm
    {
        private ClsHistorialMedico ObjHistorialMedico = null;
        private readonly ClsHistorialMedicoLn ObjHistorialMedicoLn = new ClsHistorialMedicoLn();
        public FrmHistorialMedico()
        {
            InitializeComponent();
            CargarListaHistoriasMedicas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtIdentificacion.Text == "PINGUINO345")
            {
                panel1.Visible = true; 
            }
            CargarHistoriaMedica(txtIdentificacion.Text);
        }

        private void CargarListaHistoriasMedicas()
        {
            ObjHistorialMedico = new ClsHistorialMedico();
            ObjHistorialMedicoLn.Index(ref ObjHistorialMedico);
            if (ObjHistorialMedico.MensajeError == null)
            {
                dgvHMedico.DataSource = ObjHistorialMedico.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjHistorialMedico.MensajeError, "Error Historia Medica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistoriaMedica(string ID)
        {
            ObjHistorialMedico = new ClsHistorialMedico();
            ObjHistorialMedico.IDPaciente1 = ID; // Asignar el ID del paciente
            ObjHistorialMedicoLn.ObtenerPorPacienteID(ref ObjHistorialMedico, ID); // Llamar al método para obtener el historial médico

            if (ObjHistorialMedico.MensajeError == null)
            {
                dataGridView1.DataSource = ObjHistorialMedico.DtResultados; // Mostrar resultados en el DataGridView
            }
            else
            {
                MessageBox.Show(ObjHistorialMedico.MensajeError, "Error Historial Médico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHMedico.Columns[e.ColumnIndex].Name == "Editar")
            {
                ObjHistorialMedico = new ClsHistorialMedico()
                {
                    IDHistorial1 = dgvHMedico.Rows[e.RowIndex].Cells["IDHistorial"].Value.ToString()
                };
                ObjHistorialMedicoLn.Read(ref ObjHistorialMedico);

                txtID1.Text = ObjHistorialMedico.IDHistorial1;
                txtDiagnostico1.Text = ObjHistorialMedico.Diagnostico1;
                txtTratamiento1.Text = ObjHistorialMedico.Tratamiento1;
                txtIDmedico1.Text = ObjHistorialMedico.IDMedico1;
                txtIDpaciente1.Text = ObjHistorialMedico.IDPaciente1;
                dtpFecha1.Value = ObjHistorialMedico.FechaConsulta1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                FrmUsuario frmUsuario = new FrmUsuario();
                frmUsuario.Show();
                this.Hide();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ObjHistorialMedico = new ClsHistorialMedico()
            {
                IDHistorial1 = txtID1.Text,
                Diagnostico1 = txtDiagnostico1.Text,
                Tratamiento1 = txtTratamiento1.Text,
                IDMedico1 = txtIDmedico1.Text,
                IDPaciente1 = txtIDpaciente1.Text,
                FechaConsulta1 = dtpFecha1.Value
            };
            ObjHistorialMedicoLn.Create(ref ObjHistorialMedico);
            if (ObjHistorialMedico.MensajeError == null)
            {
                MessageBox.Show("El Historial Medico: " + ObjHistorialMedico.ValorScalar + " fue agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaHistoriasMedicas();
            }
            else
            {
                MessageBox.Show(ObjHistorialMedico.MensajeError, "Error Historial Medico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObjHistorialMedico = new ClsHistorialMedico()
            {
                IDHistorial1 = txtID1.Text,
                Diagnostico1 = txtDiagnostico1.Text,
                Tratamiento1 = txtTratamiento1.Text,
                IDMedico1 = txtIDmedico1.Text,
                IDPaciente1 = txtIDpaciente1.Text,
                FechaConsulta1 = dtpFecha1.Value
            };
            ObjHistorialMedicoLn.Update(ref ObjHistorialMedico);
            if (ObjHistorialMedico.MensajeError == null)
            {
                MessageBox.Show("El Historial Medico: " + ObjHistorialMedico.ValorScalar + " fue actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaHistoriasMedicas();
            }
            else
            {
                MessageBox.Show(ObjHistorialMedico.MensajeError, "Error Historial Medico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar?", "Confirmar eliminacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                ObjHistorialMedico = new ClsHistorialMedico()
                {
                    IDHistorial1 = txtID1.Text
                };
                ObjHistorialMedicoLn.Delete(ref ObjHistorialMedico);
                if (ObjHistorialMedico.MensajeError == null)
                {
                    MessageBox.Show("El Historial Medico: " + ObjHistorialMedico.ValorScalar + " fue ELIMINADO correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaHistoriasMedicas();
                }
                else
                {
                    MessageBox.Show(ObjHistorialMedico.MensajeError, "Error Historial Medico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtID1.Text = "ID Historial";
            txtDiagnostico1.Text = "Diagnostico";
            txtTratamiento1.Text = "Tratamiento";
            txtIDpaciente1.Text = "ID Paciente";
            txtIDmedico1.Text = "ID Medico";
            dtpFecha1.Value = DateTime.Now;
        }
        #region APARIENCIA_FOCOS
        // Textos por defecto (Placeholder)
        string defaultIDText = "ID Historial";
        string defaultDiagnosticoText = "Diagnostico";
        string defaultTratamientoText = "Tratamiento";
        string defaultIDPacienteText = "ID Paciente";
        string defaultIDMedicoText = "ID Medico";
        string defaultIdentificacionText = "Ingrese ID del PACIENTE";

        // Evento para txtID1
        private void txtID1_Enter(object sender, EventArgs e)
        {
            if (txtID1.Text == defaultIDText)
            {
                txtID1.Text = "";
                txtID1.ForeColor = Color.Black;
            }
        }

        private void txtID1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID1.Text))
            {
                txtID1.Text = defaultIDText;
                txtID1.ForeColor = Color.Silver;
            }
        }

        // Evento para txtDiagnostico1
        private void txtDiagnostico1_Enter(object sender, EventArgs e)
        {
            if (txtDiagnostico1.Text == defaultDiagnosticoText)
            {
                txtDiagnostico1.Text = "";
                txtDiagnostico1.ForeColor = Color.Black;
            }
        }

        private void txtDiagnostico1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiagnostico1.Text))
            {
                txtDiagnostico1.Text = defaultDiagnosticoText;
                txtDiagnostico1.ForeColor = Color.Silver;
            }
        }

        // Evento para txtTratamiento1
        private void txtTratamiento1_Enter(object sender, EventArgs e)
        {
            if (txtTratamiento1.Text == defaultTratamientoText)
            {
                txtTratamiento1.Text = "";
                txtTratamiento1.ForeColor = Color.Black;
            }
        }

        private void txtTratamiento1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTratamiento1.Text))
            {
                txtTratamiento1.Text = defaultTratamientoText;
                txtTratamiento1.ForeColor = Color.Silver;
            }
        }

        // Evento para txtIDpaciente1
        private void txtIDpaciente1_Enter(object sender, EventArgs e)
        {
            if (txtIDpaciente1.Text == defaultIDPacienteText)
            {
                txtIDpaciente1.Text = "";
                txtIDpaciente1.ForeColor = Color.Black;
            }
        }

        private void txtIDpaciente1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDpaciente1.Text))
            {
                txtIDpaciente1.Text = defaultIDPacienteText;
                txtIDpaciente1.ForeColor = Color.Silver;
            }
        }

        // Evento para txtIDmedico1
        private void txtIDmedico1_Enter(object sender, EventArgs e)
        {
            if (txtIDmedico1.Text == defaultIDMedicoText)
            {
                txtIDmedico1.Text = "";
                txtIDmedico1.ForeColor = Color.Black;
            }
        }

        private void txtIDmedico1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDmedico1.Text))
            {
                txtIDmedico1.Text = defaultIDMedicoText;
                txtIDmedico1.ForeColor = Color.Silver;
            }
        }

        private void txtIdentificacion_Enter(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == defaultIdentificacionText)
            {
                txtIdentificacion.Text = "";
                txtIdentificacion.ForeColor = Color.Black;
            }
        }

        private void txtIdentificacion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                txtIdentificacion.Text = defaultIdentificacionText;
                txtIdentificacion.ForeColor = Color.Silver;
            }
        }


        #endregion
    }
}
