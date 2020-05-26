using System.Collections.Generic;

namespace EntidadesControlEscolar.Models
{
    /// <summary>
    /// Modelo Inscripcion
    /// Gestiona La estancia de un alumno durante un solo ciclo escolar así como se relaciona con gastos durante ese ciclo
    /// </summary>
    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        public int AlumnoId { get; set; }
        public int CicloEscolarId { get; set; }
        public int CuentaId { get; set; }
        public ICollection<int> Clases { get; set; }

        /*
            `idtminscripcion` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Id del registro',
            `idtcalumno` INT(11) NOT NULL COMMENT 'Id del registro del catalogo de Alumnos',
            `idtccicloescolar` INT(11) NOT NULL COMMENT 'Id del registro del catalogo de Ciclos escolares',
            `idtcnivelacademico` INT(11) NOT NULL COMMENT 'Id del registro del catalogo de Niveles academicos',
            `idtcgrado` INT(11) NOT NULL COMMENT 'Id del registro del catalogo de Grados',
            `grupo` VARCHAR(5) NOT NULL DEFAULT 'A' COMMENT 'Nombre abreviado del grupo',
            `fecha` DATETIME NOT NULL COMMENT 'Fecha y hora en que se registra la inscripcion',
            `estatus` INT(5) NOT NULL DEFAULT '1' COMMENT 'Estatus: 0=baja definitiva, 1=inscrito, 2=cursando, 4=baja temporal, 5=finalizado',
            `matricula` VARCHAR(12) NOT NULL COMMENT 'Generada a partir de la tabla tomatricula',
            `referenciabancaria` VARCHAR(45) NOT NULL COMMENT 'Numero de referencia bancaria para realizar sus depositas',
        */
    }
}