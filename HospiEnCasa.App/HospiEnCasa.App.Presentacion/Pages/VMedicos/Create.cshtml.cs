using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Presentacion.Pages_VMedicos
{
    
    public class CreateModel : PageModel
    {
        private readonly IRepositorioMedicoMemoria RepositorioMedicoMemoria;
        [BindProperty]
        public Medico Medico{get;set;}
        
        public CreateModel(IRepositorioMedicoMemoria RepositorioMedicoMemoria)
        {
            this.RepositorioMedicoMemoria=RepositorioMedicoMemoria;
        }
        
        
        public void OnGet()
        {
        }

       
       
        public IActionResult OnPostSave()
        {
            if (ModelState.IsValid)
            {
                Medico=RepositorioMedicoMemoria.Add(Medico);
                return RedirectToPage("Index");
            }
            else{
                return Page();
            }
        }
    }
}
