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
