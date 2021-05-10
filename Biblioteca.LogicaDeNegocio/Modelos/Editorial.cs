using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.LogicaDeNegocio.Modelos
{
    public class Editorial
    {
        [Key]
        [Column("id_editorial")]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
