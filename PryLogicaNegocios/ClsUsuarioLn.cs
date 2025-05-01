using PryAccesoDatos;
using PryEntidades;
using System.Data;

namespace PryLogicaNegocios
{
    public class ClsUsuarioLn
    {
        #region VariablePrivada

        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsUsuario ObjUsuarios)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "tbl_usuario",
                NombreSP = "[SP_Usuario_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjUsuarios);
        }

        #endregion

        public void Validar(ref ClsUsuario objUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "tbl_usuario",
                NombreSP = "[dbo].[SP_ValidarUsuario]",
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@Email", "16", objUsuario.Email); // Cambiado a @Email con mayúscula
            ObjDataBase.DtParametros.Rows.Add(@"@Contrasena", "16", objUsuario.Contrasena); // Cambiado a @Contrasena con mayúscula
            ObjDataBase.DtParametros.Rows.Add(@"@Rol", "16", objUsuario.Rol);
            Ejecutar(ref objUsuario);

        }


        private void Ejecutar(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjUsuario.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjUsuario.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjUsuario.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjUsuario.DtResultados.Rows)
                        {
                            ObjUsuario.Email = item["email"].ToString();
                            ObjUsuario.Contrasena = item["Contrasena"].ToString();
                            ObjUsuario.Rol = item["Rol"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjUsuario.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud


        public void Update(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "usuario",
                NombreSP = "[SP_usuario_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IdUsuario", "16", ObjUsuario.IdUsuario1);
            ObjDataBase.DtParametros.Rows.Add(@"@Email", "16", ObjUsuario.Email);
            ObjDataBase.DtParametros.Rows.Add(@"@Contrasena", "16", ObjUsuario.Contrasena);
            ObjDataBase.DtParametros.Rows.Add(@"@Rol", "16", ObjUsuario.Rol);

            Ejecutar(ref ObjUsuario);
        }

        public void Delete(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "usuario",
                NombreSP = "[SP_usuario_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@IdUsuario", "16", ObjUsuario.IdUsuario1);

            Ejecutar(ref ObjUsuario);
        }

        public void Read(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "usuario",
                NombreSP = "[SP_usuario_Read]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@idUsuario", "16", ObjUsuario.Email);

            Ejecutar(ref ObjUsuario);



        }
        public void Create(ref ClsUsuario objUsuario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "tbl_usuario", // Asegúrate de que coincida con tu tabla
                NombreSP = "[SP_usuario_Create]", // Procedimiento almacenado para crear un usuario
                Scalar = true // Asumimos que el SP devuelve un valor escalar, como el ID del nuevo usuario
            };

            // Agrega parámetros para el procedimiento almacenado
            ObjDataBase.DtParametros.Rows.Add(@"@Email", "16", objUsuario.Email);
            ObjDataBase.DtParametros.Rows.Add(@"@Contrasena", "16", objUsuario.Contrasena); // Asegúrate de que la contraseña esté hasheada antes
            ObjDataBase.DtParametros.Rows.Add(@"@Rol", "16", objUsuario.Rol);

            Ejecutar(ref objUsuario);

            // Aquí puedes manejar el resultado, si es necesario
            if (ObjDataBase.MensajeErrorOS == null)
            {
                // El registro fue exitoso
                objUsuario.MensajeError = null;
            }
            else
            {
                // Hubo un error al intentar registrar
                objUsuario.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #endregion
    }
}

