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
    public class DetailsModel : PageModel
    {
        public readonly IRepositorioMedicoMemoria RepositorioMedicoMemoria;
        public Medico Medico{get;set;}
        public DetailsModel(IRepositorioMedicoMemoria RepositorioMedicoMemoria)
        {
            this.RepositorioMedicoMemoria=RepositorioMedicoMemoria;

        }



        public IActionResult OnGet(int id)
        {
            Medico=RepositorioMedicoMemoria.Get(id);
            if(Medico==null)
            {
                return RedirectToPage(".NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}
