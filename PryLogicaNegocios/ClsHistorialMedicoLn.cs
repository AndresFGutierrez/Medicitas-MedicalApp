using PryAccesoDatos;
using PryEntidades;
using System;
using System.Data;

namespace PryLogicaNegocios
{
    public class ClsHistorialMedicoLn
    {
        #region VariablePrivada

        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsHistorialMedico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "HistorialMedico",
                NombreSP = "[SP_HistorialMedico_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjHistorial);
        }

        #endregion

        private void Ejecutar(ref ClsHistorialMedico ObjHistorial)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjHistorial.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjHistorial.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjHistorial.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjHistorial.DtResultados.Rows)
                        {
                            ObjHistorial.IDHistorial1 = item["IDHistorial"].ToString();
                            ObjHistorial.IDMedico1 = item["IDMedico"].ToString();
                            ObjHistorial.IDPaciente1 = item["IDPaciente"].ToString();
                            ObjHistorial.Diagnostico1 = item["Diagnostico"].ToString();
                            ObjHistorial.Tratamiento1 = item["Tratamiento"].ToString();
                            ObjHistorial.FechaConsulta1 = Convert.ToDateTime(item["FechaConsulta"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjHistorial.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        public void ObtenerPorPacienteID(ref ClsHistorialMedico ObjHistorial, string idPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "HistorialMedico",
                NombreSP = "[SP_HistorialMedico_ByPacienteID]", // Procedimiento almacenado que devuelve el historial por ID del paciente
                Scalar = false
            };

            // Añadir el parámetro para la consulta
            ObjDataBase.DtParametros.Rows.Add(@"@IDPaciente", "16", idPaciente);

            Ejecutar(ref ObjHistorial);
        }


        #region  MetodosCrud
        public void Create(ref ClsHistorialMedico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "HistorialMedico",
                NombreSP = "[SP_HistorialMedico_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDHistorial", "16", ObjHistorial.IDHistorial1);
            ObjDataBase.DtParametros.Rows.Add(@"IDPaciente", "16", ObjHistorial.IDPaciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@IDMedico", "16", ObjHistorial.IDMedico1);
            ObjDataBase.DtParametros.Rows.Add(@"@Diagnostico", "16", ObjHistorial.Diagnostico1);
            ObjDataBase.DtParametros.Rows.Add(@"@Tratamiento", "16", ObjHistorial.Tratamiento1);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaConsulta", "11", ObjHistorial.FechaConsulta1);

            Ejecutar(ref ObjHistorial);
        }

        public void Update(ref ClsHistorialMedico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "HistorialMedico",
                NombreSP = "[SP_HistorialMedico_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDHistorial", "16", ObjHistorial.IDHistorial1);
            ObjDataBase.DtParametros.Rows.Add(@"IDPaciente", "16", ObjHistorial.IDPaciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@IDMedico", "16", ObjHistorial.IDMedico1);
            ObjDataBase.DtParametros.Rows.Add(@"@Diagnostico", "16", ObjHistorial.Diagnostico1);
            ObjDataBase.DtParametros.Rows.Add(@"@Tratamiento", "16", ObjHistorial.Tratamiento1);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaConsulta", "11", ObjHistorial.FechaConsulta1);

            Ejecutar(ref ObjHistorial);
        }

        public void Delete(ref ClsHistorialMedico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "HistorialMedico",
                NombreSP = "[SP_HistorialMedico_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDHistorial", "16", ObjHistorial.IDHistorial1);


            Ejecutar(ref ObjHistorial);
        }

        public void Read(ref ClsHistorialMedico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "HistorialMedico",
                NombreSP = "[SP_HistorialMedico_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDHistorial", "16", ObjHistorial.IDHistorial1);

            Ejecutar(ref ObjHistorial);
        }
        #endregion
    }
}
