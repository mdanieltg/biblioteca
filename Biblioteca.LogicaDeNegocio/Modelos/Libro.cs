using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.LogicaDeNegocio.Modelos
{
    public class Libro
    {
        [Key]
        public ulong Isbn { get; set; }

        [Column("id_autor")]
        public int IdAutor { get; set; }

        [Column("id_editorial")]
        public int IdEditorial { get; set; }

        public string Titulo { get; set; }

        [Column("img_referencia")]
        public string ImagenReferencia { get; set; }

        [Column("year")]
        public DateTime Año { get; set; }

        public string Descripcion { get; set; }

        public int Edicion { get; set; }

        [Column("ubicacion_archivo")]
        public string UbicacionArchivo { get; set; }
    }
}
