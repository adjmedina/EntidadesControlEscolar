namespace EntidadesControlEscolar.Models
{
    /// <summary>
    /// Modelo Dirección
    /// Son las Direcciones asociadas a cada usuario
    /// </summary>
    public class DireccionTutor
    {
        /// Identificador de los datos de dirección
        public int DireccionTutorId { get; set; }
        /// Nombre de Calle
        public string Calle { get; set; }
        /// Numero interior opcional
        public int? NumeroInterior { get; set; }
        /// Número exterior obligatorio
        public int? NumeroExterior { get; set; }
        /// Referencia al identificador del INEGI asociado
        public int ClaveINEGI { get; set; }

    }
}