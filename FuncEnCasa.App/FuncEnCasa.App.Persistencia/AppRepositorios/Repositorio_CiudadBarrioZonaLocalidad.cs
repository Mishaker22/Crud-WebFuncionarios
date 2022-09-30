using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class Repositorio_CiudadBarrioZonaLocalidad : IRepositorio_CiudadBarrioZonaLocalidad
    {
        private readonly AppContext _appContext;

        public Repositorio_CiudadBarrioZonaLocalidad(AppContext contexto)
        {
            _appContext=contexto;
        }
        Ciudad_BarrioZonaLocalidad IRepositorio_CiudadBarrioZonaLocalidad.Agregar(Ciudad_BarrioZonaLocalidad ciudadBNuevo)
        {
            var ciudadBA=_appContext.Ciudad_BarrioZonaLocalidades.Add(ciudadBNuevo);
            _appContext.SaveChanges();
            return ciudadBA.Entity;
        }
        Ciudad_BarrioZonaLocalidad IRepositorio_CiudadBarrioZonaLocalidad.Modificar(Ciudad_BarrioZonaLocalidad ciudadBActualizar)
        {
            var ciudadBM=_appContext.Ciudad_BarrioZonaLocalidades.FirstOrDefault(b => b._Id==ciudadBActualizar._Id);
            if(ciudadBM!=null)
            {
                ciudadBM.ciudadId=ciudadBActualizar.ciudadId;
                ciudadBM.BarrioZLId=ciudadBActualizar.BarrioZLId;
                _appContext.SaveChanges();
            }
            return ciudadBM;
        }
        void IRepositorio_CiudadBarrioZonaLocalidad.Eliminar(int id)
        {
            var barrioZB=_appContext.Ciudad_BarrioZonaLocalidades.FirstOrDefault(b => b._Id==id);
            if (barrioZB !=null)
            {
                _appContext.Ciudad_BarrioZonaLocalidades.Remove(barrioZB);
                _appContext.SaveChanges();
            }
        }
        Ciudad_BarrioZonaLocalidad IRepositorio_CiudadBarrioZonaLocalidad.ObtenerId(int id)
        {
            return _appContext.Ciudad_BarrioZonaLocalidades.FirstOrDefault(b => b._Id==id);
        }
       
        IEnumerable<Ciudad_BarrioZonaLocalidad> IRepositorio_CiudadBarrioZonaLocalidad.ObtenerTodos()
        {
            return _appContext.Ciudad_BarrioZonaLocalidades;
        }
    }
}