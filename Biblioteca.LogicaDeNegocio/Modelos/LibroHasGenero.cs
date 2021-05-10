using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.LogicaDeNegocio.Modelos
{
    public class LibroHasGenero
    {
        [Key, Column("id_lhg")]
        public int Id { get; set; }

        [Column("id_libro")]
        public ulong Isbn { get; set; }

        [Column("id_genero")]
        public int IdGenero { get; set; }
    }
}
