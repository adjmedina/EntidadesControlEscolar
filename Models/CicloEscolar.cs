using System;
using System.Collections.Generic;

namespace EntidadesControlEscolar.Models
{
    /// <summary>
    /// Modelo Ciclo Escolar
    /// Gestiona La información correspondiente al ciclo escolar
    /// </summary>
    public class CicloEscolar
    {
        public int CicloEscolarId { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }

        // ------------ Referencias a Entidades -------------
        /// Referencia a objeto Inscripcion 
        public ICollection<Inscripcion> Inscripcion { get; set; }





    }
}