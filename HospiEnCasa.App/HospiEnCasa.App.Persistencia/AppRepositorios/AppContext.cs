using System;
using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    { 
        //Colocamos solamente las entidades, género y tipo signo son enum 
        
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Enfermera> Enfermeras {get;set;}
        public DbSet<Medico> Medicos {get;set;}
        public DbSet<FamiliarDesignado> FamiliarDesignados {get;set;}
        public DbSet<Historia> Historias {get;set;}
        public DbSet<SugerenciaCuidado> SugerenciaCuidados {get;set;}
        public DbSet<SignoVital> SignoVitales {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}

    //Código con el que creamos la base de datos.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog= HospiEnCasaBD");

            } 
        }


    }
}