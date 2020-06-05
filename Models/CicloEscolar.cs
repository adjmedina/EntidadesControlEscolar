using System;

namespace EntidadesControlEscolar.Models
{
    /// <summary>
    /// Modelo Ciclo Escolar
    /// Gestiona La información correspondiente al ciclo escolar
    /// </summary>
    public class CicloEscolar
    {
        public int CicloEscolarId { get; set; }
        public string titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }


    }
}