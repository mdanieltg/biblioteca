using System;
using Biblioteca.LogicaDeNegocio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.ApiWeb.Controladores
{
    [ApiController]
    [Route("api/autor")]
    public class ControladorAutor : ControllerBase
    {
        private IRepositorioBiblioteca _repositorio;

        public ControladorAutor(IRepositorioBiblioteca repositorioBiblioteca)
        {
            _repositorio = repositorioBiblioteca ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public IActionResult ObtenerAutores()
        {
            var autores = _repositorio.ObtenerAutores();
            return Ok(autores);
        }
    }
}
