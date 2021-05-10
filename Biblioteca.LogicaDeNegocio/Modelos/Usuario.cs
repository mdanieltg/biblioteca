using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.LogicaDeNegocio.Modelos
{
    public class Usuario
    {
        [Key]
        [Column("id_usuario")]
        public string Id { get; set; }

        public string Tipo { get; set; }

        public string Nombre { get; set; }

        [Column("nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        public string Correo { get; set; }

        [Column("psswd")]
        public string Contraseña { get; set; }
    }
}
