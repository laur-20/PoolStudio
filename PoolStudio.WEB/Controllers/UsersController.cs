using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PoolStudio.WEB.Controllers
{
    public class UsersController : Controller
    {

        // [Route] = se puede utilizar para modificar una url, tanto para el controlador como para los métodos (index, edit, delete, etc).

        public IActionResult Index(int id)
        {
            /*
               var url = Url.Action("Index", "Users", new
            {
                y = DateTime.Now.Year,
                m = DateTime.Now.Month,
                d = DateTime.Now.Day,
                h = DateTime.Now.Hour,
                ms = DateTime.Now.Minute,
                s = DateTime.Now.Second,
                mlls = DateTime.Now.Millisecond
            });
            */

            ViewData["id"] = id;
            return View();
        }
    }
}
