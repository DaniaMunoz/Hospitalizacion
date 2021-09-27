using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    
    public interface IRepositorioMedicoMemoria
    {
        IEnumerable<Medico> GetAll();
        Medico Add(Medico medico);
        Medico Update (Medico medico);
        void Delete (int idMedico);
        Medico Get (int idMedico);

    }
}