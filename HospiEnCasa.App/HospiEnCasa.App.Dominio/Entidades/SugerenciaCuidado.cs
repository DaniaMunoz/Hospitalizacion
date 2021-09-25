using System;

namespace HospiEnCasa.App.Dominio
{
    ///<sumary>Class <c>SugerenciaCuidado</c>
    ///Modela una sugerencia de cuidado
    ///</sumary>
    public class SugerenciaCuidado 
    {
        //Identificador único de cada sugerencia de cuidado
        public int Id {get;set;}//No refactorizamos
        /// Fecha y hora en que se escribe la sugerencia
        public DateTime FechaHora {get;set;}
        //Texto con la sugerencia
        public string Descripcion {get;set;}

    }
}