using System.Collections.Generic;
using Biblioteca.LogicaDeNegocio.Modelos;

namespace Biblioteca.LogicaDeNegocio.Servicios
{
    public interface IRepositorioBiblioteca
    {
        IEnumerable<Autor> ObtenerAutores();
        Autor ObtenerAutor(int idAutor);
    }
}
