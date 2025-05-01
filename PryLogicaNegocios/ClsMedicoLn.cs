using PryAccesoDatos;
using PryEntidades;
using System;
using System.Data;

namespace PryLogicaNegocios
{
    public class ClsMedicoLn
    {
        #region VariablePrivada

        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsMedico ObjMedico)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Medico",
                NombreSP = "[SP_Medico_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjMedico);
        }

        #endregion

        private void Ejecutar(ref ClsMedico ObjMedico)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjMedico.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjMedico.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjMedico.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjMedico.DtResultados.Rows)
                        {
                            ObjMedico.IDMedico1 = item["IDMedico"].ToString();
                            ObjMedico.Nombre1 = item["Nombre"].ToString();
                            ObjMedico.Especialidad1 = item["Especialidad"].ToString();
                            ObjMedico.Telefono1 = item["Telefono"].ToString();
                            ObjMedico.Genero1 = item["Genero"].ToString();
                            ObjMedico.FechaNacimiento1 = Convert.ToDateTime(item["FechaNacimiento"].ToString());
                            ObjMedico.HorarioAtencion1 = TimeSpan.Parse(item["HorarioAtencion"].ToString());

                        }
                    }
                }
            }
            else
            {
                ObjMedico.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        public void Create(ref ClsMedico ObjMedico)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Medico",
                NombreSP = "[SP_Medico_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDMedico", "16", ObjMedico.IDMedico1);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "16", ObjMedico.Nombre1);
            ObjDataBase.DtParametros.Rows.Add(@"@Especialidad", "16", ObjMedico.Especialidad1);
            ObjDataBase.DtParametros.Rows.Add(@"@Telefono", "16", ObjMedico.Telefono1);
            ObjDataBase.DtParametros.Rows.Add(@"@Genero", "16", ObjMedico.Genero1);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaNacimiento", "11", ObjMedico.FechaNacimiento1);
            ObjDataBase.DtParametros.Rows.Add(@"@HorarioAtencion", "12", ObjMedico.HorarioAtencion1);

            Ejecutar(ref ObjMedico);
        }

        public void Update(ref ClsMedico ObjMedico)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Medico",
                NombreSP = "[SP_Medico_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDMedico", "16", ObjMedico.IDMedico1);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "16", ObjMedico.Nombre1);
            ObjDataBase.DtParametros.Rows.Add(@"@Especialidad", "16", ObjMedico.Especialidad1);
            ObjDataBase.DtParametros.Rows.Add(@"@Telefono", "16", ObjMedico.Telefono1);
            ObjDataBase.DtParametros.Rows.Add(@"@Genero", "16", ObjMedico.Genero1);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaNacimiento", "11", ObjMedico.FechaNacimiento1);
            ObjDataBase.DtParametros.Rows.Add(@"@HorarioAtencion", "12", ObjMedico.HorarioAtencion1);

            Ejecutar(ref ObjMedico);
        }

        public void Delete(ref ClsMedico ObjMedico)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Medico",
                NombreSP = "[SP_Medico_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDMedico", "16", ObjMedico.IDMedico1);


            Ejecutar(ref ObjMedico);
        }

        public void Read(ref ClsMedico ObjMedico)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Medico",
                NombreSP = "[SP_Medico_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDMedico", "16", ObjMedico.IDMedico1);

            Ejecutar(ref ObjMedico);
        }
        #endregion
    }
}
