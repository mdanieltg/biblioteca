using System;
using Biblioteca.LogicaDeNegocio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.ApiWeb.Controladores
{
    [ApiController]
    [Route("api/usuario")]
    public class ControladorUsuario : ControllerBase
    {
        private IRepositorioBiblioteca _repositorio;

        public ControladorUsuario(IRepositorioBiblioteca repositorio)
        {
            _repositorio = repositorio ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public IActionResult ObtenerUsuarios()
        {
            var usuarios = _repositorio.ObtenerUsuarios();
            return Ok(usuarios);
        }
    }
}
