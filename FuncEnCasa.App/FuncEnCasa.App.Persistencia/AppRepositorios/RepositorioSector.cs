using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioSector : IRepositorioSector
    {
        private readonly AppContext _appContext;

        public RepositorioSector(AppContext contexto)
        {
            _appContext=contexto;
        }
        Sector IRepositorioSector.Agregar(Sector sectorNuevo)
        {
            var sectorA=_appContext.Sectores.Add(sectorNuevo);
            _appContext.SaveChanges();
            return sectorA.Entity;
        }
        Sector IRepositorioSector.Modificar(Sector sectorActualizar)
        {
            var sectorM=_appContext.Sectores.FirstOrDefault(s => s._Id==sectorActualizar._Id);
            if(sectorM!=null)
            {
                sectorM.nombreSector=sectorActualizar.nombreSector;
                _appContext.SaveChanges();
            }
            return sectorM;
        }
        void IRepositorioSector.Eliminar(int id)
        {
            var sectorB=_appContext.Sectores.FirstOrDefault(s => s._Id==id);
            if (sectorB !=null)
            {
                _appContext.Sectores.Remove(sectorB);
                _appContext.SaveChanges();
            }
        }
        Sector IRepositorioSector.ObtenerId(int id)
        {
            return _appContext.Sectores.FirstOrDefault(s => s._Id==id);
        }
       
        IEnumerable<Sector> IRepositorioSector.ObtenerTodos()
        {
            return _appContext.Sectores;
        }
    }
}