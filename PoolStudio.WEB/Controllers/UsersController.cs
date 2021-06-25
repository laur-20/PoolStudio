using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PoolStudio.WEB.Controllers
{
    public class UsersController : Controller
    {

        //[Route] = se puede utilizar para modificar una url, tanto para el controlador como para los métodos (index, edit, delete, etc).

        public IActionResult Index(int id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
