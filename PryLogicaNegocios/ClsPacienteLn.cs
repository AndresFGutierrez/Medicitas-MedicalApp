using PryAccesoDatos;
using PryEntidades;
using System;
using System.Data;

namespace PryLogicaNegocios
{
    public class ClsPacienteLn
    {
        #region VariablePrivada

        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjPaciente);
        }

        #endregion

        private void Ejecutar(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjPaciente.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjPaciente.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjPaciente.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjPaciente.DtResultados.Rows)
                        {
                            ObjPaciente.IDPaciente1 = item["IDPaciente"].ToString();
                            ObjPaciente.Nombre1 = item["Nombre"].ToString();
                            ObjPaciente.Direccion1 = item["Direccion"].ToString();
                            ObjPaciente.Telefono1 = item["Telefono"].ToString();
                            ObjPaciente.Genero1 = item["Genero"].ToString();
                            ObjPaciente.FechaNacimiento1 = Convert.ToDateTime(item["FechaNacimiento"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjPaciente.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        public void Create(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDPaciente", "16", ObjPaciente.IDPaciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "16", ObjPaciente.Nombre1);
            ObjDataBase.DtParametros.Rows.Add(@"@Direccion", "16", ObjPaciente.Direccion1);
            ObjDataBase.DtParametros.Rows.Add(@"@Telefono", "16", ObjPaciente.Telefono1);
            ObjDataBase.DtParametros.Rows.Add(@"@Genero", "16", ObjPaciente.Genero1);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaNacimiento", "11", ObjPaciente.FechaNacimiento1);

            Ejecutar(ref ObjPaciente);
        }

        public void Update(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDPaciente", "16", ObjPaciente.IDPaciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "16", ObjPaciente.Nombre1);
            ObjDataBase.DtParametros.Rows.Add(@"@Direccion", "16", ObjPaciente.Direccion1);
            ObjDataBase.DtParametros.Rows.Add(@"@Telefono", "16", ObjPaciente.Telefono1);
            ObjDataBase.DtParametros.Rows.Add(@"@Genero", "16", ObjPaciente.Genero1);
            ObjDataBase.DtParametros.Rows.Add(@"@FechaNacimiento", "11", ObjPaciente.FechaNacimiento1);

            Ejecutar(ref ObjPaciente);
        }

        public void Delete(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDPaciente", "16", ObjPaciente.IDPaciente1);


            Ejecutar(ref ObjPaciente);
        }

        public void Read(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IDPaciente", "16", ObjPaciente.IDPaciente1);

            Ejecutar(ref ObjPaciente);
        }
        #endregion


    }
}
