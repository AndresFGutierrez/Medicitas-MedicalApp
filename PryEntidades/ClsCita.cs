using System;
using System.Data;

namespace PryEntidades
{
    public class ClsCita
    {
        #region AtributosPrivados

        string IDCita, DescripcionCita, Estado, IDPaciente, IDMedico;
        private DateTime FechayHora;
        private TimeSpan Hora;


        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion


        #region AtributosPublicos
        public string IDCita1 { get => IDCita; set => IDCita = value; }
        public string DescripcionCita1 { get => DescripcionCita; set => DescripcionCita = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string IDPaciente1 { get => IDPaciente; set => IDPaciente = value; }
        public string IDMedico1 { get => IDMedico; set => IDMedico = value; }
        public DateTime FechayHora1 { get => FechayHora; set => FechayHora = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        public TimeSpan Hora1 { get => Hora; set => Hora = value; }

        #endregion
    }
}
