using System;
namespace EntidadesControlEscolar.Models
{
    public class Aula
    {
        public int AulaId { get; set; }
        public string Nombre { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public int Dia { get; set; }
        public string Descripcion { get; set; }

        // ------------ Referencias a Entidades -------------

        public int OfertaAcademicaId { get; set; }
        public OfertaAcademica OfertaAcademica { get; set; }
    }
}