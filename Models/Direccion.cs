namespace EntidadesControlEscolar.Models
{
    /// <summary>
    /// Modelo Dirección
    /// Son las Direcciones asociadas a cada usuario
    /// </summary>
    public class Direccion
    {
        public int DireccionId { get; set; }
        public string Calle { get; set; }
        public int NumeroInterior { get; set; }
        public int NumeroExterior { get; set; }
        public int ClaveINEGI { get; set; }

    }
}