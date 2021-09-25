using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class AddMedicoModel : PageModel
    {
        public void OnGet()
        {
        }

        //Código para usar modelo de médico
        [BindProperty]
        public Medico Medico {get;set;}

        //Validacion si escriben especialidad medica
        public IActionResult OnPostSave() //Save viene de AddMedico.html
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("GetMedicos");
            }
            else 
            {
                return Page();
            }
        }
    }
}
