using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;//Añadimos
using HospiEnCasa.App.Dominio;//Añadimos


namespace HospiEnCasa.App.Presentacion.Pages_Pacientes
{
    public class IndexModel : PageModel
    {
        //Añadimos readonly dentro de la CLASE 
        private readonly IRepositorioPacienteMemoria RepositorioPacienteMemoria;
        public IEnumerable<Paciente> Pacientes {get;set;}
        
        //Constructor
        public IndexModel (IRepositorioPacienteMemoria RepositorioPacienteMemoria)
        {
            this.RepositorioPacienteMemoria=RepositorioPacienteMemoria;
        }


        public void OnGet()
        {
            Pacientes=RepositorioPacienteMemoria.GetAll();
        }
    }
}
