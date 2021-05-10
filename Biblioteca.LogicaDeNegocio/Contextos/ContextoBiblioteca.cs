using Biblioteca.LogicaDeNegocio.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.LogicaDeNegocio.Contextos
{
    public class ContextoBiblioteca : DbContext
    {
        public ContextoBiblioteca(DbContextOptions<ContextoBiblioteca> options) : base(options)
        {
        }

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Editorial> Editorial { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<LibroHasGenero> LibroGenero { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Favorito> Favorito { get; set; }
    }
}
