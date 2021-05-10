using Biblioteca.LogicaDeNegocio.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.LogicaDeNegocio.Contextos
{
    public class ContextoBiblioteca : DbContext
    {
        public ContextoBiblioteca(DbContextOptions<ContextoBiblioteca> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<LibroHasGenero> LibroHasGeneros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Favorito> Favoritos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(builder => builder.ToTable("Autor"));
            modelBuilder.Entity<Genero>(builder => builder.ToTable("Genero"));
            modelBuilder.Entity<Editorial>(builder => builder.ToTable("Editorial"));
            modelBuilder.Entity<Libro>(builder => builder.ToTable("Libro"));
            modelBuilder.Entity<LibroHasGenero>(builder => builder.ToTable("LibroHasGenero"));
            modelBuilder.Entity<Usuario>(builder => builder.ToTable("Usuario"));
            modelBuilder.Entity<Favorito>(builder => builder.ToTable("Favorito"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
