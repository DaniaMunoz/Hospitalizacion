using System.Collections.Generic;
using HospiEnCasa.App.Dominio; 
using System; //Importante incluirlo
using System.Linq;//Importante incluirlo


namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPacienteMemoria: IRepositorioPacienteMemoria
    {
        
        List<Paciente> Pacientes;
        
        //Creamos método constructor donde inicializamos variables
        public RepositorioPacienteMemoria()
        {

            Pacientes=new List<Paciente>() //Aquí es donde almacenamos la info mientras 
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
        
        
        public IEnumerable<Paciente> GetFilter(string filtro=null)
        {
            var pacientes= GetAll();
            if (pacientes!= null) //Filtro para que existan pacientes
            {
                if(!String.IsNullOrEmpty(filtro))
                {
                    pacientes=pacientes.Where(p=> p.Nombre.Contains(filtro));
                }
            }
            return pacientes;
        }
        

        public Paciente Add(Paciente paciente)
        {
            paciente.Id=Pacientes.Max(p=>p.Id)+1;
            Pacientes.Add(paciente);
            return paciente;
        }


        public Paciente Update (Paciente paciente)
        {
            var pacienteEncontrado=Pacientes.SingleOrDefault(p=>p.Id==paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Apellidos=paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono=paciente.NumeroTelefono;
                pacienteEncontrado.Genero=paciente.Genero;
                pacienteEncontrado.Direccion=paciente.Direccion;
                pacienteEncontrado.Latitud=paciente.Latitud;
                pacienteEncontrado.Longitud=paciente.Longitud;
                pacienteEncontrado.Ciudad=paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;

            }
            return pacienteEncontrado;
        }


        public void Delete(int idPaciente)
        {
            var paciente=Pacientes.SingleOrDefault(p=>p.Id==idPaciente);
            if (paciente==null)
                return;
                Pacientes.Remove(paciente);
        }


        public Paciente Get(int idPaciente)
        {
            return Pacientes.SingleOrDefault(p=>p.Id==idPaciente);
        }

        //Nuevo asignar médico
        Medico IRepositorioPacienteMemoria.ToAssignMedico(int idPaciente, Medico medico)
        {
            var pacienteEncontrado=Pacientes.SingleOrDefault(p=>p.Id==idPaciente);
            if (pacienteEncontrado!=null)
            {
                pacienteEncontrado.Medico=medico;
                return medico;
            }
            return null;

        }

    }
}