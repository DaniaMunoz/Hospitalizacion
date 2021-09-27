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
                    Especialidad="Dermatólogo"
                },

                new Medico
                {
                    Id=2,
                    Nombre= "Julia",
                    Apellidos= "Mera",
                    NumeroTelefono="3004598",
                    Genero= Genero.Masculino,
                    Especialidad="Cardiólogo"
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


        public Medico Add(Medico medico)
        {
            throw new NotImplementedException();
        }


        public Medico Update (Medico medico)
        {
            throw new NotImplementedException();
        }


        public void Delete(int idMedico)
        {
            throw new NotImplementedException();
        }


        public Medico Get(int idMedico)
        {
            throw new NotImplementedException();
        }
    }
}