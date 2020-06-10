using System.Collections.Generic;

namespace EntidadesControlEscolar.Models
{
    public class Asignatura
    {
        public int AsignaturaId { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public int NumeroHoras { get; set; }

        // ------------ Referencias a Entidades -------------
        public ICollection<OfertaAcademica> OfertaAcademicaLink { get; set; }

    }
}