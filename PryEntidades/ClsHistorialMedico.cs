using System;
using System.Data;

namespace PryEntidades
{
    public class ClsHistorialMedico
    {
        #region AtributosPrivados

        string IDHistorial, IDPaciente, IDMedico, Diagnostico, Tratamiento;
        DateTime FechaConsulta;

        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion


        #region AtributosPublicos

        public string IDHistorial1 { get => IDHistorial; set => IDHistorial = value; }
        public string IDPaciente1 { get => IDPaciente; set => IDPaciente = value; }
        public string IDMedico1 { get => IDMedico; set => IDMedico = value; }
        public string Diagnostico1 { get => Diagnostico; set => Diagnostico = value; }
        public string Tratamiento1 { get => Tratamiento; set => Tratamiento = value; }
        public DateTime FechaConsulta1 { get => FechaConsulta; set => FechaConsulta = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }
        #endregion
    }
}
