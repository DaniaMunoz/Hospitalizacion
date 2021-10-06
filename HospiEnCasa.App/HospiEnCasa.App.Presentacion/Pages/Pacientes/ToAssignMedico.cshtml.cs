using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Presentacion.Pages_Pacientes
{
    public class ToAssignMedicoModel : PageModel
    {
        
        private readonly IRepositorioMedicoMemoria RepositorioMedicoMemoria;
        private readonly IRepositorioPacienteMemoria RepositorioPacienteMemoria;
        public IEnumerable<Medico> Medicos{get;set;}
        [BindProperty(SupportsGet=true)]
        public string GetFilters{get;set;}
        [BindProperty]
        public int medicoId{get;set;}
        [BindProperty]
        public Medico Medico {get;set;}
        [BindProperty]
        public Paciente Paciente {get;set;}

        public ToAssignMedicoModel(IRepositorioPacienteMemoria RepositorioPacienteMemoria, IRepositorioMedicoMemoria RepositorioMedicoMemoria) 
        {
            this.RepositorioMedicoMemoria=RepositorioMedicoMemoria;
            this.RepositorioPacienteMemoria=RepositorioPacienteMemoria;
        }
        public IActionResult OnGet(int id)
        {
            Medicos=RepositorioMedicoMemoria.GetAll();
            Paciente=RepositorioPacienteMemoria.Get(id);
            if (Paciente==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPostToAssign(int medicoId)
        {
            Medico=RepositorioMedicoMemoria.Get(medicoId);
            Medico=RepositorioPacienteMemoria.ToAssignMedico(Paciente.Id, Medico);
            return RedirectToPage("./Index");
        }
    }
}
