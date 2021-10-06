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
    public class IndexModel : PageModel
    {
        
        //Añadimos readonly dentro de la CLASE 
        private readonly IRepositorioMedicoMemoria RepositorioMedicoMemoria;
        public IEnumerable<Medico> Medicos {get;set;}
        
        //Clase 27 sept
        [BindProperty(SupportsGet=true)]
        public string GetFilters {get;set;}

        //Constructor
        public IndexModel (IRepositorioMedicoMemoria RepositorioMedicoMemoria)
        {
            this.RepositorioMedicoMemoria=RepositorioMedicoMemoria;
        }

        public void OnGet(string GetFilters)
        {
            //Medicos=RepositorioMedicoMemoria.GetAll();
            Medicos=RepositorioMedicoMemoria.GetFilter(GetFilters);
        }
    }
}
