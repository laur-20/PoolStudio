using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PoolStudio.WEB.Areas.Usuario.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet(string data)
        {
            Message = data;
        }
    }
}
