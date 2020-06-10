using System;
using System.Collections.Generic;

namespace EntidadesControlEscolar.Models
{
    /// <summary>
    /// Modelo Inscripcion
    /// Gestiona La estancia de un alumno durante un solo ciclo escolar así como se relaciona con gastos durante ese ciclo
    /// </summary>
    public class Inscripcion
    {
        /// Id del registro
        public int InscripcionId { get; set; }
        /// Id del ALumno relacionado
        public int AlumnoId { get; set; }
        /// Id del Ciclo escolar relacionado
        public int CicloEscolarId { get; set; }
        /// id del la cuenta asociada al alumno
        public int GrupoId { get; set; }
        /// Vicula con la cuenta del alumno 
        public int CuentaId { get; set; }
        /// Vinculo a una lista de clases
        public ICollection<int> Clases { get; set; } //Cambiar esta linea
        /// Fecha en que se registro la inscripción
        public DateTime FechaInscripcion { get; set; }
        /// 0=baja definitiva, 1=inscrito, 4=baja temporal, 5=finalizado
        public int EstadoInscripcion { get; set; }

        // ------------ Referencias a Entidades -------------

        /// Link a objeto alumno
        public Alumno Alumno { get; set; }
        /// Link a objeto Curso
        public ICollection<Curso> Curso { get; set; }


    }
}