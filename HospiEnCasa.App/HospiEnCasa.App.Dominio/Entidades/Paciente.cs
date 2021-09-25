using System;

namespace HospiEnCasa.App.Dominio 
{
    public class Paciente : Persona
    {
        //
        public string Direccion {get;set;}
        //Coordenada direccion del paciente
        public float Latitud {get;set;}
        //Coordenada direccion del paciente
        public float Longitud {get;set;}
        //Ciudad de residencia del paciente
        public string Ciudad {get;set;}
        //Fecha de nacimiento del paciente
        public DateTime FechaNacimiento {get;set;}

        //Relacion entre paciente y su historia
        public Historia Historia {get;set;}
        //Relacion entre paciente y su Enfermera que lo atiende
        public Enfermera Enfermera {get;set;}
        //Relacion entre paciente y su FamiliarDesignado para cuidarlo
        public FamiliarDesignado Familiar {get;set;}
        //Relación entre paciente y Medico que lo atiende
        public Medico Medico {get;set;}

        ///<sumary>
        ///Referencia a la lista de signos vitales de un Paciente
        ///</sumary>
        ///<value></value>
        public System.Collections.Generic.List<SignoVital> SignosVitales {get;set;}

    }

}