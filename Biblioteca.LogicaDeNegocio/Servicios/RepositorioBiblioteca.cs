using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.LogicaDeNegocio.Contextos;
using Biblioteca.LogicaDeNegocio.Modelos;

namespace Biblioteca.LogicaDeNegocio.Servicios
{
    public class RepositorioBiblioteca : IRepositorioBiblioteca, IDisposable
    {
        private ContextoBiblioteca _db;

        public RepositorioBiblioteca(ContextoBiblioteca contextoBiblioteca)
        {
            _db = contextoBiblioteca;
        }

        public IEnumerable<Autor> ObtenerAutores()
        {
            return _db.Autores.ToList();
        }

        public Autor ObtenerAutor(int idAutor)
        {
            return _db.Autores.FirstOrDefault(a => a.Id == idAutor);
        }

        public IEnumerable<Editorial> ObtenerEditoriales()
        {
            return _db.Editoriales.ToList();
        }

        public Editorial ObtenerEditorial(int idEditorial)
        {
            return _db.Editoriales.FirstOrDefault(e => e.Id == idEditorial);
        }

        public IEnumerable<Genero> ObtenerGeneros()
        {
            return _db.Generos.ToList();
        }

        public Genero ObtenerGenero(int idGenero)
        {
            return _db.Generos.FirstOrDefault(g => g.Id == idGenero);
        }

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            return _db.Usuarios.ToList();
        }

        public Usuario ObtenerUsuario(string idUsuario)
        {
            return _db.Usuarios.FirstOrDefault(u => u.Id == idUsuario);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
    }
}
