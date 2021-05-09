using System;

namespace Biblioteca.BusinessLogic
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public TipoUsuario Tipo { get; set; }
    }
}
