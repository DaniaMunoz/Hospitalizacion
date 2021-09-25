using System;
using System.ComponentModel.DataAnnotations; //Importante para la página web ponerlo 

 

namespace HospiEnCasa.App.Dominio
{
    ///<sumary>Class <c>Medico</c>
    ///Modela un Medico en el sistema
    ///</sumary>
    public class Medico : Persona
    {
        
        ///Nombre de la especialidad médica del médico
        [Required (ErrorMessage= "Ingrese la especialidad médica")] //Mensaje de error que aparece 
        public string Especialidad{get;set;}//No refactorizamos
        /// código unico del medico
        [Required (ErrorMessage= "Ingrese el código")]
        public string Codigo{get;set;}
        /// Registro Unico Nacional de TTHH
        [Required (ErrorMessage= "Ingrese el Registro Rethus")]
        public string RegistroRethus{get;set;}
        
        

    }
}