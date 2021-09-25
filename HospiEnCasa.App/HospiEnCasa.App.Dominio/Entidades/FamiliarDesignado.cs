using System;

namespace HospiEnCasa.App.Dominio
{
    ///<sumary>Class <c>FamiliarDesignado</c>
    ///Modela un Familiar Designado en el sistema
    ///</sumary>
    public class FamiliarDesignado : Persona
    {
        ///Parentesco con el enfermo
        public string Parentesco {get;set;}
        /// Direccion correo electrónico
        public string Correo {get;set;} 

    }
}