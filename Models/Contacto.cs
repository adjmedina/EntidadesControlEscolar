namespace EntidadesControlEscolar.Models
{
    /// <summary>
    /// Modelo Contacto
    /// Representa la informacion que registra el usuario para ser contactado
    /// Puede ser email, Celular, telefono-casa
    /// </summary>
    public class ContactoTutor
    {
        /// Identificador del contacto 
        public int ContactoTutorId { get; set; }
        ///Representa el tipo de contacto que define
        public TipoContacto Tipo { get; set; }
        ///  Representa el dato en si
        public string Valor { get; set; }
    }
}


/// <summary>
/// Posibles tipos de contactos asociados
/// </summary>enum TipoContacto
public enum TipoContacto
{
    /// Telefono de casa o fijo
    Telefono,
    /// Telefono Movil
    Celular,

}