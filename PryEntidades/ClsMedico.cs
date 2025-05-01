using System;
using System.Data;

namespace PryEntidades
{
    public class ClsMedico
    {
        #region AtributosPrivados

        string IDMedico, Nombre, Especialidad, Telefono, Genero;
        DateTime FechaNacimiento;
        TimeSpan HorarioAtencion;

        //Atributos para el manejo de la base de datos
        private string mensajeError, valorScalar;
        private DataTable dtResultados;
        #endregion

        public ClsMedico() { }

        public ClsMedico(string iDMedico, string nombre, string especialidad, string telefono, string genero, DateTime fechaNacimiento, TimeSpan horarioAtencion)
        {
            IDMedico = iDMedico;
            Nombre = nombre;
            Especialidad = especialidad;
            Telefono = telefono;
            Genero = genero;
            FechaNacimiento = fechaNacimiento;
            HorarioAtencion = horarioAtencion;
        }


        #region AtributosPublicos

        public string IDMedico1 { get => IDMedico; set => IDMedico = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Especialidad1 { get => Especialidad; set => Especialidad = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public TimeSpan HorarioAtencion1 { get => HorarioAtencion; set => HorarioAtencion = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public DataTable DtResultados { get => dtResultados; set => dtResultados = value; }



        #endregion

    }
}
