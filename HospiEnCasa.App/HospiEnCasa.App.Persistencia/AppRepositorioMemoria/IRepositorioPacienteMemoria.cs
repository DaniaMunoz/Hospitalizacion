using System.Collections.Generic;
using HospiEnCasa.App.Dominio; //Importante ponerlo 



namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPacienteMemoria
    {
        IEnumerable<Paciente> GetAll();
        Paciente Add(Paciente paciente);
        Paciente Update (Paciente paciente);
        void Delete(int idPaciente);
        Paciente Get(int idPaciente);
    }
}