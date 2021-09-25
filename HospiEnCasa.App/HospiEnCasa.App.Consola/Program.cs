using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente (new Persistencia.AppContext());
        private static IRepositorioMedico _repoMedico= new RepositorioMedico (new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //BuscarPaciente();
            //UpdatePaciente();
            //AsignarMedico();
        }

        private static void AddPaciente ()
        {
            var paciente= new Paciente
            {
                Nombre= "Jose",
                Apellidos= "García",
                NumeroTelefono= "123456",
                Genero= Genero.Masculino,
                Direccion= "Calle 6# 34-02",
                Longitud= -5.0707F,
                Latitud= -75.52290F,
                Ciudad= "Cali",
                FechaNacimiento= new DateTime(1995,05,09)
            };
            _repoPaciente.AddPaciente(paciente);
        }

        private static void GetPaciente (int idPaciente)
        {
            var paciente= _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine (paciente.Nombre+" "+paciente.Apellidos);
        }

        private static void UpdatePaciente (Paciente paciente)
        {
            var paciente1= _repoPaciente.UpdatePaciente(paciente);
            Console.WriteLine (paciente1.Nombre+" "+paciente1.Apellidos);
        }

        private static void GetAllPaciente ()
        {
            var pacientes= _repoPaciente.GetAllPaciente(); //El nombre de la variable puede ser cualquiera
            foreach(var Paciente in pacientes) //el Paciente indica es la entidad como tal, que tiene sus atributos
            {
                Console.WriteLine("Paciente: "+Paciente.Nombre+" "+Paciente.Apellidos);
            }
        }

        private static void DeletePaciente (int idPaciente) // Es void, no devuelve nada
        {
            _repoPaciente.DeletePaciente(idPaciente);
            
        }



        //Inicia código CRUD  de médico ---------------------
        private static void AddMedico ()
        {
            var medico= new Medico
            {
                Nombre= "Lucía",
                Apellidos= "Gutierrez",
                NumeroTelefono= "123456",
                Genero= Genero.Femenino,
                Especialidad="Oncóloga",
                Codigo="456789",
                RegistroRethus= "1597894"
               
            };
            _repoMedico.AddMedico(medico);
        }

        //Método asignar médico
        private static void AsignarMedico()
        {
        var medico = _repoPaciente.AsignarMedico(1,2); //El 1 y 2 infdican el id del paciente y médico en la BD
        Console.WriteLine(medico.Nombre+" "+medico.Apellidos);
        }
        

    //Ubicamos antes de estos dos para pegar cualquier otro CRUD de las demás entidades    
    }
}
