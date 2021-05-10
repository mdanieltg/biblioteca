using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.LogicaDeNegocio.Modelos
{
    public class Favorito
    {
        [Key, Column("id_favorito")]
        public long Id { get; set; }

        [Column("id_usuario")]
        public string IdUsuario { get; set; }

        [Column("id_libro")]
        public long Isbn { get; set; }
    }
}
