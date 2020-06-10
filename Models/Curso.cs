using System.Collections.Generic;

namespace EntidadesControlEscolar.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public int Calificacion { get; set; }

        // ------------ Referencias a Entidades -------------

        /// Link a inscripciones
        public int InscripcionId { get; set; }
        public Inscripcion Inscripcion { get; set; }

        public int OfertaAcademicaId { get; set; }
        public OfertaAcademica OfertaAcademica { get; set; }
    }
}