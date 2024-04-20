using L02P02_2019TM602_2020MZ602.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace L02P02_2019TM602_2020MZ602.Controllers
{
    public class usuariosController : Controller

    {
        private readonly usuariosDbContext _usuariosDbContext;

        public usuariosController(usuariosDbContext usuariosDbContexto)
        {
            _usuariosDbContext = usuariosDbContexto;
        }


        public IActionResult Index()
        {





            var listaDeNombres = (from n in _usuariosDbContext.clientes
                                  select n).ToList();
            ViewData["listadoDeNombres"] = new SelectList(listaDeNombres, "nombre", "apellido", "email", "direccion");


            return View();
        }
    }
}
