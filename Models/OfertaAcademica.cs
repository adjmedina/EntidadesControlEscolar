using System.Collections.Generic;

namespace EntidadesControlEscolar.Models
{
    public class OfertaAcademica
    {
        public int OfertaAcademicaId { get; set; }


        // ------------ Referencias a Entidades -------------

        public int AulaId { get; set; }

        public Aula Aula { get; set; }

        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }

        public int AsignaturaId { get; set; }

        public Asignatura Asignatura { get; set; }

        public ICollection<Sesion> SesionLink { get; set; }
    }
}