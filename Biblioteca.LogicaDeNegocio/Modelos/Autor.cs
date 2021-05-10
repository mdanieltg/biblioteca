using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.LogicaDeNegocio.Modelos
{
    public class Autor
    {
        [Key]
        [Column("id_autor")]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
