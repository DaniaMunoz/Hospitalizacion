using System;

namespace HospiEnCasa.App.Dominio
{
    ///<sumary>Class <c>Enfermera</c>
    ///Modela un Enfermera en el sistema
    ///</sumary>
    public class Enfermera : Persona
    {
        ///Numero unico de la tarjeta profesional
        public string TarjetaProfesional{get;set;}
        /// Cantidad de horas laborales a la semana
        public int HorasLaborales{get;set;} 

    }
}
