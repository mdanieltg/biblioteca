using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Biblioteca.BusinessLogic
{
    public class Libro
    {
        public long Isbn { get; set; }
        public int GeneroId { get; set; }
        public int AutorId { get; set; }
        public int EditorialId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImagenReferencia { get; set; }
        public int Año { get; set; }
        public int Edicion { get; set; }
        public string UbicacionArchivo { get; set; }
    }
}
