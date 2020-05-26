namespace EntidadesControlEscolar.Models
{
    /// <summary>
    /// Modelo Tutor
    /// Relacion Muchos a muchos con alumno
    /// </summary>
    public class AlumnoTutor
    {
        /// Identificador Unico de alumno
        public int AlumnoId { get; set; }
        /// Identificador Unico de Tutor
        public int TutorId { get; set; }

        // Referencias a las Otras Clases

        ///Relaciona A un Alumno
        public Alumno Alumno { get; set; }
        ///Relaciona A un Tutor
        public Tutor Tutor { get; set; }
    }
}


//// UNA INSCRIPCION CADA CICLO