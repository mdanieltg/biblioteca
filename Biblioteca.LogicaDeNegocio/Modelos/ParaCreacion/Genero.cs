using System.ComponentModel.DataAnnotations;

namespace Biblioteca.LogicaDeNegocio.Modelos.ParaCreacion
{
    public class Genero
    {
        [MaxLength(20)]
        public string Nombre { get; set; }
    }
}
