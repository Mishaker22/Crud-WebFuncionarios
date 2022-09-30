using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class Repositorio_BarrioZonaLocalidad : IRepositorio_BarrioZonaLocalidad
    {
        private readonly AppContext _appContext;

        public Repositorio_BarrioZonaLocalidad(AppContext contexto)
        {
            _appContext=contexto;
        }
        Barrio_ZonaLocalidad IRepositorio_BarrioZonaLocalidad.Agregar(Barrio_ZonaLocalidad barrioZoNuevo)
        {
            var barrioZA=_appContext.Barri_ZonaLocalidades.Add(barrioZoNuevo);
            _appContext.SaveChanges();
            return barrioZA.Entity;
        }
        Barrio_ZonaLocalidad IRepositorio_BarrioZonaLocalidad.Modificar(Barrio_ZonaLocalidad barrioZActualizar)
        {
            var barrioZM=_appContext.Barri_ZonaLocalidades.FirstOrDefault(b => b._Id==barrioZActualizar._Id);
            if(barrioZM!=null)
            {
                barrioZM.barrioId=barrioZActualizar.barrioId;
                barrioZM.ZonaLId=barrioZActualizar.ZonaLId;
                _appContext.SaveChanges();
            }
            return barrioZM;
        }
        void IRepositorio_BarrioZonaLocalidad.Eliminar(int id)
        {
            var barrioZB=_appContext.Barri_ZonaLocalidades.FirstOrDefault(b => b._Id==id);
            if (barrioZB !=null)
            {
                _appContext.Barri_ZonaLocalidades.Remove(barrioZB);
                _appContext.SaveChanges();
            }
        }
        Barrio_ZonaLocalidad IRepositorio_BarrioZonaLocalidad.ObtenerId(int id)
        {
            return _appContext.Barri_ZonaLocalidades.FirstOrDefault(b => b._Id==id);
        }
       
        IEnumerable<Barrio_ZonaLocalidad> IRepositorio_BarrioZonaLocalidad.ObtenerTodos()
        {
            return _appContext.Barri_ZonaLocalidades;
        }
    }
}