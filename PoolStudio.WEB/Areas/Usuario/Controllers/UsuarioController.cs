using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolStudio.WEB.Areas.Usuario.Controllers
{
    public class UsuarioController : Controller
    {
        [Area("Usuario")]
        public IActionResult Usuario()
        {
            return View();
        }
    }
}
