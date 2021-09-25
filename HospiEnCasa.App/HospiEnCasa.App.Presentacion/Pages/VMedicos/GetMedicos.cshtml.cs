using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio; //Añadimos para que reconozca a los médicos

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class GetMedicosModel : PageModel
    {
        //Creamos lista de médicos
        public List<Medico> ListaMedicos{get;set;}
        public IEnumerable<Medico> Medicos {get;set;} //Añadimos esto
        
        public GetMedicosModel() //Cosntructor
        {
            
            Medico M1= new Medico
            {
            Id=1,
            Nombre= "Martin",
            Apellidos= "Valenzuela",
            NumeroTelefono="3004598",
            Genero= Genero.Masculino,
            Especialidad="Pediatría",
            Codigo="456789",
            RegistroRethus="4444"
            };

        Medico M2= new Medico
        {
            Id=2,
            Nombre= "Tatiana",
            Apellidos= "Ramirez",
            NumeroTelefono="3004598",
            Genero= Genero.Femenino,
            Especialidad="Neurología",
            Codigo="456789",
            RegistroRethus="4444"
        };


        Medico M3= new Medico
        {
            Id=3,
            Nombre= "Rubeira",
            Apellidos= "Muñoz",
            NumeroTelefono="456000",
            Genero= Genero.Femenino,
            Especialidad="Cardiología",
            Codigo="456789",
            RegistroRethus="5555"
        };
       
        

        Medicos= new List<Medico>{M1,M2, M3};//Añadimos esto 
         }
        
        public void OnGet()
        {
            ListaMedicos= new List<Medico>();
            ListaMedicos.AddRange(Medicos);
        }
    }
}
