using System.Collections.Generic;
using HospiEnCasa.App.Dominio; 
using System; //Importante incluirlo
using System.Linq;//Importante incluirlo


namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPacienteMemoria: IRepositorioPacienteMemoria
    {
        
        List<Paciente> Pacientes;
        
        //Creamos método constructor
        public RepositorioPacienteMemoria()
        {

            Pacientes=new List<Paciente>()
            {
                new Paciente
                {
                    Id=1,
                    Nombre= "Martin",
                    Apellidos= "Valenzuela",
                    NumeroTelefono="3004598",
                    Genero= Genero.Masculino,
                    Direccion="Calle 4",
                    Longitud=55,
                    Latitud=70,
                    Ciudad="Buga",
                    FechaNacimiento=new DateTime(1995,05,05)
                },

                new Paciente
                {
                    Id=2,
                    Nombre= "Julia",
                    Apellidos= "Mera",
                    NumeroTelefono="3004598",
                    Genero= Genero.Masculino,
                    Direccion="Calle 4",
                    Longitud=55,
                    Latitud=70,
                    Ciudad="Tuluá",
                    FechaNacimiento=new DateTime(1999,05,05)
                }
            };
        }
        
    
        public IEnumerable<Paciente> GetAll()
        {
            return Pacientes; //Retorna la lista que se llama pacientes
        }
        

        public Paciente Add(Paciente paciente)
        {
            throw new NotImplementedException();
        }


        public Paciente Update (Paciente paciente)
        {
            throw new NotImplementedException();
        }


        public void Delete(int idPaciente)
        {
            throw new NotImplementedException();
        }


        public Paciente Get(int idPaciente)
        {
            throw new NotImplementedException();
        }
    }
}