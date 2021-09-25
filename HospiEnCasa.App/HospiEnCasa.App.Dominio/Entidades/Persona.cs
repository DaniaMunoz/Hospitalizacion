using System;
using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    ///<sumary>Class <c>Persona</c>
    ///Modela una persona en el sistema
    ///</sumary>
    public class Persona 
    {
        //Identificador único de cada Persona
        public int Id{get;set;}//No refactorizamos
        [Required (ErrorMessage= "Ingrese el nombre")]
        
        public string Nombre{get;set;}
        [Required (ErrorMessage= "Ingrese el apellido")]
        
        public string Apellidos{get;set;}
        [Required (ErrorMessage= "Ingrese el número de teléfono")]
        public string NumeroTelefono{get;set;}
        //Genero de la persona >> Relación de asociación
        
        public Genero Genero {get;set;}

    }
}
