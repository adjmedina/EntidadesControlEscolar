using System;
using System.Collections.Generic;

namespace EntidadesControlEscolar.Models
{

    /// <summary>
    /// Modelo Alumno
    /// Se relaciona con los Modelos 
    /// </summary>
    public class Alumno
    {
        /// Identificador de Alumno
        public int AlumnoId { get; set; }
        ///Matricula Generada por el año de Inscripcion .!--.!--.!--.!-- Preguntar qie sucede si hay una movilidad y llega a un grado de estudios avanzado
        public string Matricula { get; set; }
        /// Nombres del Alumno
        public string Nombre { get; set; }
        /// Apellido Paterno
        public string ApellidoPaterno { get; set; }
        /// Apellido Materno opcional
        public string ApellidoMaterno { get; set; }
        /// Sexo del Alumno
        public Sexo Sexo { get; set; }
        /// Curp 16 caracteres
        public string Curp { get; set; }
        /// Fecha De nacimiento DD/MM/AA
        public DateTime FechaNacimiento { get; set; }
        /// Fecha De Ingreso a la institucion DD/MM/AA
        public DateTime FechaRegistro { get; set; }

        // ------------ Referencias a Entidades -------------

        /// Link a Inscripcion
        public ICollection<Inscripcion> Inscripciones { get; set; }

        /// Link a Tutotes Asociados
        public ICollection<Tutor> Tutores { get; set; }

    }

    /// <summary>
    /// Enumera los tipos de sexo
    /// </summary>
    public enum Sexo
    {
        /// 0) Hombre
        Hombre,
        /// 1) Mujer
        Mujer
    }
}