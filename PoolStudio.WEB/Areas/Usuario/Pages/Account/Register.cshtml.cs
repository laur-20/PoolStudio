using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PoolStudio.WEB.Areas.Usuario.Pages.Account
{
    public class RegisterModel : PageModel
    {
       
        public void OnGet()
        {
           
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage ="Este campo es obligatorio.")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage ="Este campo es obligatorio.")]
            [DataType(DataType.Password)]
            [Display(Name = "Contrase�a")]
            [StringLength(100, ErrorMessage = "El n�mero de caracteres de {0} debe ser de al menos {2}.", MinimumLength = 6)]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "La confirmaci�n de la contrase�a no coincide con la contrase�a.")]
            public string ConfirmPassword { get; set; }


            [Required]
            public string ErrorMessage { get; set; }
        }
        public IActionResult OnPost() 
        {
            if(ModelState.IsValid)
            {
                 
            }
            else
            {
                ModelState.AddModelError("Input.Email", "Se ha generado un error en el servidor.");
            }
            var data = Input;
            return Page();
        } 
    }
}
