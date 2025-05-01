using PryAccesoDatos;
using PryEntidades;
using System;
using System.Data;

namespace PryLogicaNegocios
{
    public class ClsCitasLn
    {
        #region VariablePrivada

        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsCita ObjCitas)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjCitas);
        }

        #endregion

        private void Ejecutar(ref ClsCita ObjCita)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjCita.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjCita.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjCita.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjCita.DtResultados.Rows)
                        {
                            ObjCita.IDCita1 = item["IDCita"].ToString();
                            ObjCita.IDMedico1 = item["IDMedico"].ToString();
                            ObjCita.IDPaciente1 = item["IdPaciente"].ToString();
                            ObjCita.Estado1 = item["Estado"].ToString();
                            ObjCita.DescripcionCita1 = item["DescripcionCita"].ToString();

                            // Convertir FechayHora a DateTime y luego extraer la hora
                            ObjCita.FechayHora1 = Convert.ToDateTime(item["FechayHora"].ToString());

                            // Extraer la hora de FechayHora (por ejemplo, para mostrar solo la hora)
                            ObjCita.Hora1 = ObjCita.FechayHora1.TimeOfDay;  // Devuelve un TimeSpan con la hora, minuto y segundo
                        }
                    }
                }
            }
            else
            {
                ObjCita.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }


        #region  MetodosCrud
        public void Create(ref ClsCita Objcita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDCita", "16", Objcita.IDCita1);
            ObjDataBase.DtParametros.Rows.Add(@"@IDMedico", "16", Objcita.IDMedico1);
            ObjDataBase.DtParametros.Rows.Add(@"@FechayHora", "11", Objcita.FechayHora1);
            ObjDataBase.DtParametros.Rows.Add(@"@DescripcionCita", "16", Objcita.DescripcionCita1);
            ObjDataBase.DtParametros.Rows.Add(@"@IdPaciente", "16", Objcita.IDPaciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "16", Objcita.Estado1);

            Ejecutar(ref Objcita);
        }

        public void Update(ref ClsCita Objcita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDCita", "16", Objcita.IDCita1);
            ObjDataBase.DtParametros.Rows.Add(@"@IDMedico", "16", Objcita.IDMedico1);
            ObjDataBase.DtParametros.Rows.Add(@"@FechayHora", "11", Objcita.FechayHora1);
            ObjDataBase.DtParametros.Rows.Add(@"@DescripcionCita", "16", Objcita.DescripcionCita1);
            ObjDataBase.DtParametros.Rows.Add(@"@IdPaciente", "16", Objcita.IDPaciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "16", Objcita.Estado1);

            Ejecutar(ref Objcita);
        }

        public void Delete(ref ClsCita Objcita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDCita", "16", Objcita.IDCita1);

            Ejecutar(ref Objcita);
        }

        public void Read(ref ClsCita Objcita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDCita", "16", Objcita.IDCita1);


            Ejecutar(ref Objcita);
        }
        #endregion
    }
}