using System;

namespace CapaEntidad
{
    public class Interlocutor
    {
        public int IdInterlocutor { get; set; }
        public string Login { get; set; }
        public string Clave { get; set; }
        public Rol oRol{ get; set; }
        public int IdRol { get; set; }
        public String Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string FechaRegistro { get; set; }
        public string FechaModificacion { get; set; }
        public int IdInterlocutorModificacion { get; set; }
        public bool Estado { get; set; }
    }
}
