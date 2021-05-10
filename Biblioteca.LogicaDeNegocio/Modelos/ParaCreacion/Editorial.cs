using System.ComponentModel.DataAnnotations;

namespace Biblioteca.LogicaDeNegocio.Modelos.ParaCreacion
{
    public class Editorial
    {
        [MaxLength(40)]
        public string Nombre { get; set; }
    }
}
