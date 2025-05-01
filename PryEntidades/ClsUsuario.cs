using System.Data;


namespace PryEntidades
{
    public class ClsUsuario
    {
        #region AtributosPrivados
        private string email, contrasena, rol, IdUsuario;

        // Atributos para la conxion de base datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;

        #endregion

        #region AtributosPublicos

        public string Email { get => email; set => email = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Rol { get => rol; set => rol = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        public string IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }

        #endregion
    }
}
