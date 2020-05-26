namespace EntidadesControlEscolar.Models
{
    public class DatoContacto
    {
        public int DatoContactoId { get; set; }
        public int TipoContacto { get; set; }
        public string Dato { get; set; }
    }
}


enum TipoContacto
{
    Telefono,
    Mail,

}