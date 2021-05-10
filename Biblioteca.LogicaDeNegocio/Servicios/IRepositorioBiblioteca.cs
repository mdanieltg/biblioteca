using System.Collections.Generic;
using Biblioteca.LogicaDeNegocio.Modelos;

namespace Biblioteca.LogicaDeNegocio.Servicios
{
    public interface IRepositorioBiblioteca
    {
        // Autores
        IEnumerable<Autor> ObtenerAutores();
        Autor ObtenerAutor(int idAutor);
        // void ActualizarAutor(Autor autor);
        // void CrearAutor(Autor autor);
        // void EliminarAutor(Autor autor);

        // Editoriales
        IEnumerable<Editorial> ObtenerEditoriales();
        Editorial ObtenerEditorial(int idEditorial);
        // void ActualizarEditorial(Editorial editorial);
        // void CrearEditorial(Editorial editorial);
        // void EliminarEditorial(Editorial editorial);

        // Géneros
        IEnumerable<Genero> ObtenerGeneros();
        Genero ObtenerGenero(int idGenero);
        // void ActualizarGenero(Genero genero);
        // void CrearGenero(Genero genero);
        // void EliminarGenero(Genero genero);
        
        // Libro
        // IEnumerable<Libro> ObtenerLibros();
        // Libro ObtenerLibro(ulong idLibro);
        // void ActualizarLibro(Libro libro);
        // void CrearLibro(Libro libro);
        // void EliminarLibro(Libro libro);
        
        // Usuario
        IEnumerable<Usuario> ObtenerUsuarios();
        Usuario ObtenerUsuario(string idUsuario);
        // void ActualizarUsuario(Usuario usuario);
        // void CrearUsuario(Usuario usuario);
        // void EliminarUsuario(Usuario usuario);
        
        // Favoritos
        // IEnumerable<Favorito> ObtenerFavoritos();
        // Favorito ObtenerFavorito(int idFavorito);
        // void ActualizarFavorito(Favorito favorito);
        // void CrearFavorito(Favorito favorito);
        // void EliminarFavorito(Favorito favorito);

        bool Save();
    }
}
