using System;
using System.Data;

namespace PryEntidades
{
    public class ClsPaciente
    {
        #region AtributosPrivados

        string IDPaciente, Nombre, Direccion, Telefono, Genero;
        DateTime FechaNacimiento;

        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion

        #region AtributosPublicos

        public string IDPaciente1 { get => IDPaciente; set => IDPaciente = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }

        #endregion

    }
}
