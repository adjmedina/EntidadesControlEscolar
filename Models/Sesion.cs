namespace EntidadesControlEscolar.Models
{
    public class Sesion
    {
        public int SesionId { get; set; }

        /// Solicitar la info de la sesion

        // ------------ Referencias a Entidades -------------

        public int OfertaAcademicaId { get; set; }
        public OfertaAcademica OfertaAcademica { get; set; }
    }
}