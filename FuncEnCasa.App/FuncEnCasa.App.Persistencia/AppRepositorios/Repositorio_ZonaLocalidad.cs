using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class Repositorio_ZonaLocalidad : IRepositorio_ZonaLocalidad
    {
        private readonly AppContext _appContext;

        public Repositorio_ZonaLocalidad(AppContext contexto)
        {
            _appContext=contexto;
        }
        Zona_Localidad IRepositorio_ZonaLocalidad.Agregar(Zona_Localidad zonaLoNueva)
        {
            var zonaLoA=_appContext.Zona_Localidades.Add(zonaLoNueva);
            _appContext.SaveChanges();
            return zonaLoA.Entity;
        }
        Zona_Localidad IRepositorio_ZonaLocalidad.Modificar(Zona_Localidad zonaLoActualizar)
        {
            var zonaLoM=_appContext.Zona_Localidades.FirstOrDefault(a => a._Id==zonaLoActualizar._Id);
            if(zonaLoM!=null)
            {
                zonaLoM.zonaId=zonaLoActualizar.zonaId;
                zonaLoM.sectorId=zonaLoActualizar.sectorId;
                _appContext.SaveChanges();
            }
            return zonaLoM;
        }
        void IRepositorio_ZonaLocalidad.Eliminar(int id)
        {
            var zonaLoB=_appContext.Zona_Localidades.FirstOrDefault(a => a._Id==id);
            if (zonaLoB !=null)
            {
                _appContext.Zona_Localidades.Remove(zonaLoB);
                _appContext.SaveChanges();
            }
        }
        Zona_Localidad IRepositorio_ZonaLocalidad.ObtenerId(int id)
        {
            return _appContext.Zona_Localidades.FirstOrDefault(a => a._Id==id);
        }
       
        IEnumerable<Zona_Localidad> IRepositorio_ZonaLocalidad.ObtenerTodos()
        {
            return _appContext.Zona_Localidades;
        }
    }
}