using System;

namespace HospiEnCasa.App.Dominio
{
    ///<sumary>Class <c>SignoVital</c>
    ///Modela una signo vital
    ///</sumary>
    public class SignoVital 
    {
        //Identificador único de signo vital
        public int Id {get;set;}//No refactorizamos
        /// Fecha y hora en que se realizó la toma 
        public DateTime FechaHora {get;set;}
        ///Valor numerico signo vital
        public float Valor{get;set;}
        //Tipo de signo vital
        public TipoSigno Signo {get;set;}

    }
}