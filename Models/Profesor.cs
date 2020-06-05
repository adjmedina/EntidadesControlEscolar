using System;

namespace EntidadesControlEscolar.Models
{
    /// <summary>
    /// Modelo Profesor
    /// Se relaciona con los Modelos 
    /// </summary>
    public class Profesor
    {
        /// Identificador de Profesor
        public int ProfesorId { get; set; }
        /// Nombres del Profesord
        public string Nombre { get; set; }
        /// Apellido Paterno
        public string ApellidoPaterno { get; set; }
        /// Apellido Materno opcional
        public string ApellidoMaterno { get; set; }
        /// Sexo del Profesor
        public Sexo Sexo { get; set; }
        /// Curp 16 caracteres
        public string Curp { get; set; }
        /// Fecha DD/MM/AA
        public DateTime FechaNacimiento { get; set; }
    }
}