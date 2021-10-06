using System.Collections.Generic;
using HospiEnCasa.App.Dominio; 
using System; //Importante incluirlo
using System.Linq;//Importante incluirlo


namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedicoMemoria: IRepositorioMedicoMemoria
    {
        
        List<Medico> Medicos;
        
        //Creamos método constructor donde inicializamos variables
        public RepositorioMedicoMemoria()
        {

            Medicos=new List<Medico>() //Aquí es donde almacenamos la info mientras 
            {
                new Medico
                {
                    Id=1,
                    Nombre= "Martin",
                    Apellidos= "Valenzuela",
                    NumeroTelefono="3004598",
                    Genero= Genero.Masculino,
                    Especialidad="Dermatólogo",
                    Codigo="789",
                    RegistroRethus="111"
                },

                new Medico
                {
                    Id=2,
                    Nombre= "Julia",
                    Apellidos= "Mera",
                    NumeroTelefono="3004598",
                    Genero= Genero.Masculino,
                    Especialidad="Cardiólogo",
                    Codigo="789",
                    RegistroRethus="999"
                }
            };
        }
        
    
        public IEnumerable<Medico> GetAll()
        {
            return Medicos; //Retorna la lista que se llama pacientes
        }
        

        public IEnumerable<Medico> GetFilter(string filtro=null)
        {
            var medicos= GetAll();
            if (medicos!= null) //Filtro para que existan pacientes
            {
                if(!String.IsNullOrEmpty(filtro))
                {
                    medicos=medicos.Where(m=> m.Nombre.Contains(filtro));
                }
            }
            return medicos;
        }


        public Medico Add(Medico Medico)
        {
            Medico.Id=Medicos.Max(m=>m.Id)+1;
            Medicos.Add(Medico);
            return Medico;
        }


        public Medico Update (Medico medico)
        {
            var medicoEncontrado=Medicos.SingleOrDefault(m=>m.Id==medico.Id);
            if (medicoEncontrado != null)
            {
                medicoEncontrado.Nombre=medico.Nombre;
                medicoEncontrado.Apellidos=medico.Apellidos;
                medicoEncontrado.NumeroTelefono=medico.NumeroTelefono;
                medicoEncontrado.Genero=medico.Genero;
                medicoEncontrado.Especialidad=medico.Especialidad;
                medicoEncontrado.Codigo=medico.Codigo;
                medicoEncontrado.RegistroRethus=medico.RegistroRethus;

            }
            return medicoEncontrado;

        }


        public void Delete(int idMedico)
        {
            var medico=Medicos.SingleOrDefault(m=>m.Id==idMedico);
            if (medico==null)
                return;
                Medicos.Remove(medico);
        }


        public Medico Get(int idMedico)
        {
            return Medicos.SingleOrDefault(m=>m.Id==idMedico);
        }
    }
}