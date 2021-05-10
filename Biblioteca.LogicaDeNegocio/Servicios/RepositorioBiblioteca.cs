using System.Collections.Generic;
using System.Linq;
using Biblioteca.LogicaDeNegocio.Contextos;
using Biblioteca.LogicaDeNegocio.Modelos;

namespace Biblioteca.LogicaDeNegocio.Servicios
{
    public class RepositorioBiblioteca : IRepositorioBiblioteca
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
    }
}
