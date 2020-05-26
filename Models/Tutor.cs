using System;

namespace EntidadesControlEscolar.Models
{

    /// <summary>
    /// Modelo Tutor
    /// Se relaciona con los Modelos 
    /// </summary>
    public class Tutor
    {
        /// Identificador de Tutor
        public int TutorId { get; set; }
        /// Nombres del Tutor
        public string Nombre { get; set; }
        /// Apellido Paterno
        public string ApellidoPaterno { get; set; }
        /// Apellido Materno opcional
        public string ApellidoMaterno { get; set; }
        /// Sexo del Tutor
        public Sexo Sexo { get; set; }
        /// Curp 16 caracteres
        public string Curp { get; set; }
        /// Fecha DD/MM/AA
        public DateTime FechaNacimiento { get; set; }


    }

}