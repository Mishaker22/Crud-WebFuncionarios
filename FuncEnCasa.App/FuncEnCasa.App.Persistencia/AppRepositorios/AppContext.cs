using Microsoft.EntityFrameworkCore;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public class AppContext: DbContext
    {
        public DbSet<Area> Areas {get;set;} 
        public DbSet<Barrio> Barrios{get;set;}
        public DbSet<Ciudad> Ciudades{get;set;}
        public DbSet<Correo> Correos{get;set;}
        public DbSet<Departamento> Departamentos{get;set;}
        public DbSet<Direccion> Direcciones{get;set;}
        public DbSet<Funcionario> Funcionarios{get;set;}
        public DbSet<Jerarquia> Jerarquias{get;set;}
        public DbSet<Pais> Paises{get;set;}
        public DbSet<Sector> Sectores{get;set;}
        public DbSet<Sucursal> Sucursales{get;set;}
        public DbSet<Telefono> Telefonos{get;set;}
        public DbSet<TipoVivienda> TipoViviendas{get;set;}
        public DbSet<Usuario> Usuarios{get;set;}
        public DbSet<Zona> Zonas{get;set;}
        public DbSet<Barrio_ZonaLocalidad> Barri_ZonaLocalidades{get;set;}
        public DbSet<Correo_Usuario> CorreoUsuarios{get;set;}
        public DbSet<Telefono_Usuario> TelefonoUsuarios{get;set;}
        public DbSet<Ciudad_BarrioZonaLocalidad> Ciudad_BarrioZonaLocalidades{get;set;}
        public DbSet<Ciudad_Departamento> Ciudad_Departamentos{get;set;}
        public DbSet<Pais_Departamento> Pais_Departamentos{get;set;}
        public DbSet<TipoVivienda_Barrio> TipoVivienda_Barrios{get;set;}
        public DbSet<Zona_Localidad> Zona_Localidades{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasIndex(u=> new {u._Id}).IsUnique(true);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=ProgramingLife_Ciclo3");
            }
        }

    }
}