using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocios;

namespace PryPresentacion
{
    public partial class FrmCitas : MaterialForm
    {
        private ClsCita ObjCitas = null;
        private readonly ClsCitasLn ObjCitasLn = new ClsCitasLn();
        public FrmCitas()
        {
            InitializeComponent();
            CargarListaCitas();
        }

        private void CargarListaCitas()
        {
            ObjCitas = new ClsCita();
            ObjCitasLn.Index(ref ObjCitas);
            if (ObjCitas.MensajeError == null)
            {
                dtvListaCitas.DataSource = ObjCitas.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjCitas.MensajeError, "Error Patrones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
      

            // Asignar valores a ClsCita
            ObjCitas = new ClsCita()
            {
                IDCita1 = txtIdCita.Text,
                IDPaciente1 = txtIdPaciente.Text,
                IDMedico1 = txtIdMedico.Text,
                Estado1 = txtEstado.Text,
                DescripcionCita1 = txtDescripcion.Text,
                FechayHora1 = dtpFecha.Value, // Usar fecha y hora combinadas
            };

            // Insertar la cita en la base de datos
            ObjCitasLn.Create(ref ObjCitas);

            if (ObjCitas.MensajeError == null)
            {
                MessageBox.Show("La cita: " + ObjCitas.ValorScalar + " fue agregada correctamente",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaCitas();
            }
            else
            {
                MessageBox.Show(ObjCitas.MensajeError, "Error Citas",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpiar los campos
            txtIdCita.Text = "";
            txtIdPaciente.Text = "";
            dtpFecha.Value = DateTime.Now;
            txtIdMedico.Text = "";
            txtDescripcion.Text = "";
            txtEstado.Text = "";
            txtHora.Text = "00:00 a.m";
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener la fecha del DateTimePicker
            DateTime fecha = dtpFecha.Value.Date;

            // Obtener la hora del TextBox y verificar si es válida
            string horaTexto = txtHora.Text.Trim();
            TimeSpan hora;

            if (!TimeSpan.TryParse(horaTexto, out hora))
            {
                MessageBox.Show("Formato de hora inválido. Por favor ingresa una hora válida (HH:mm).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si la hora no es válida
            }

            // Combinar fecha y hora
            DateTime fechaCompleta = fecha.Add(hora);

            // Asignar valores a ClsCita
            ObjCitas = new ClsCita()
            {
                IDCita1 = txtIdCita.Text,
                IDPaciente1 = txtIdPaciente.Text,
                IDMedico1 = txtIdMedico.Text,
                Estado1 = txtEstado.Text,
                DescripcionCita1 = txtDescripcion.Text,
                FechayHora1 = fechaCompleta, // Usar fecha y hora combinadas
            };

            // Actualizar la cita en la base de datos
            ObjCitasLn.Update(ref ObjCitas);

            if (ObjCitas.MensajeError == null)
            {
                MessageBox.Show("La cita: " + ObjCitas.ValorScalar + " fue actualizada correctamente",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaCitas();
            }
            else
            {
                MessageBox.Show(ObjCitas.MensajeError, "Error Citas",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpiar los campos
            txtIdCita.Text = "";
            txtIdPaciente.Text = "";
            dtpFecha.Value = DateTime.Now;
            txtIdMedico.Text = "";
            txtDescripcion.Text = "";
            txtEstado.Text = "";
            txtHora.Text = "00:00";
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar?", "Confirmar eliminacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                ObjCitas = new ClsCita()
                {
                    IDCita1 = txtIdCita.Text,
                };
                ObjCitasLn.Delete(ref ObjCitas);
                if (ObjCitas.MensajeError == null)
                {
                    MessageBox.Show("La cita: " + ObjCitas.ValorScalar + " fue ELIMINADO correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaCitas();
                }
                else
                {
                    MessageBox.Show(ObjCitas.MensajeError, "Error citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtIdCita.Text = "";
                txtIdPaciente.Text = "";
                dtpFecha.Value = DateTime.Now;
                txtIdMedico.Text = "";
                txtDescripcion.Text = "";
                txtEstado.Text = "";
                txtHora.Text = "00:00";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                FrmMedico frmMedico = new FrmMedico();
                frmMedico.Show();
                this.Hide();
            }
        }

        private void dtvListaCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvListaCitas.Columns[e.ColumnIndex].Name == "Editar")
            {
                ObjCitas = new ClsCita()
                {
                    IDCita1 = dtvListaCitas.Rows[e.RowIndex].Cells["IDCita"].Value.ToString(),
                };
                ObjCitasLn.Read(ref ObjCitas);

                txtIdCita.Text = ObjCitas.IDCita1;
                txtIdPaciente.Text = ObjCitas.IDPaciente1;
                txtIdMedico.Text = ObjCitas.IDMedico1;
                txtEstado.Text = ObjCitas.Estado1;
                txtDescripcion.Text = ObjCitas.DescripcionCita1;
                dtpFecha.MinDate = ObjCitas.FechayHora1;
                txtHora.Text = DateTime.Today.Add(ObjCitas.Hora1).ToShortTimeString();
            }
        }

        #region textbox cita
        private void txtIdCita_Enter(object sender, EventArgs e)
        {

        }

        private void txtIdCita_Leave(object sender, EventArgs e)
        {

        }

        private void txtIdPaciente_Enter(object sender, EventArgs e)
        {

        }

        private void txtIdPaciente_Leave(object sender, EventArgs e)
        {

        }

        private void txtIdMedico_Enter(object sender, EventArgs e)
        {

        }

        private void txtIdMedico_Leave(object sender, EventArgs e)
        {

        }

        private void txtHora_Enter(object sender, EventArgs e)
        {

        }

        private void txtHora_Leave(object sender, EventArgs e)
        {

        }

        private void txtEstado_Enter(object sender, EventArgs e)
        {

        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
