using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Presentacion.Pages_Pacientes
{
    
    public class DetailsModel : PageModel
    {
        public readonly IRepositorioPacienteMemoria RepositorioPacienteMemoria;
        public Paciente Paciente{get;set;}
        public Medico Medico {get;set;} //Agrega al médico
        public DetailsModel(IRepositorioPacienteMemoria RepositorioPacienteMemoria)
        {
            this.RepositorioPacienteMemoria=RepositorioPacienteMemoria;

        }



        public IActionResult OnGet(int id)
        {
            Paciente=RepositorioPacienteMemoria.Get(id);
            if(Paciente==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                if (Paciente.Medico==null) //Adicionamos esta parte
                {
                    Medico=new Medico
                    {
                        Nombre="Sin asignar"
                    };
                    Paciente.Medico=Medico;
                }
                return Page();
            }
        }  
    }
}
