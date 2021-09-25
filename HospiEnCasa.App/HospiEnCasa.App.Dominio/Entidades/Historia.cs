using System;


namespace HospiEnCasa.App.Dominio
{
    ///<sumary>Class <c>Historia</c>
    ///Modela una Historia en el sistema
    ///</sumary>

    public class Historia
    {
        //Identificador unico de la historia
        public int Id {get;set;}
        //Descripcion detallada del diagnóstico del paciente
        public string Diagnostico {get;set;}
        //Descripción de la casa y habitación del paciente
        public string Entorno {get;set;}
        //Referencia la Lista de sugerencias registradas en la historia del paciente
        public System.Collections.Generic.List<SugerenciaCuidado> Sugerencias {get;set;}

    }

}