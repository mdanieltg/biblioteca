using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.LogicaDeNegocio.Modelos
{
    public class Genero
    {
        [Key, Column("id_genero")]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
