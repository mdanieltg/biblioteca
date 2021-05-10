using System.ComponentModel.DataAnnotations;

namespace Biblioteca.LogicaDeNegocio.Modelos.ParaCreacion
{
    public class Autor
    {
        [MaxLength(50)]
        public string Nombre { get; set; }
    }
}
