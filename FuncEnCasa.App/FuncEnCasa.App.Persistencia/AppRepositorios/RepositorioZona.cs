using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioZona : IRepositorioZona
    {
        private readonly AppContext _appContext;

        public RepositorioZona(AppContext contexto)
        {
            _appContext=contexto;
        }
        Zona IRepositorioZona.Agregar(Zona zonaNueva)
        {
            var zonaA=_appContext.Zonas.Add(zonaNueva);
            _appContext.SaveChanges();
            return zonaA.Entity;
        }
        Zona IRepositorioZona.Modificar(Zona zonaActualizar)
        {
            var zonaM=_appContext.Zonas.FirstOrDefault(z => z._Id==zonaActualizar._Id);
            if(zonaM!=null)
            {
                zonaM.nombreZona=zonaActualizar.nombreZona;
                _appContext.SaveChanges();
            }
            return zonaM;
        }
        void IRepositorioZona.Eliminar(int id)
        {
            var zonaB=_appContext.Zonas.FirstOrDefault(z => z._Id==id);
            if (zonaB !=null)
            {
                _appContext.Zonas.Remove(zonaB);
                _appContext.SaveChanges();
            }
        }
        Zona IRepositorioZona.ObtenerId(int id)
        {
            return _appContext.Zonas.FirstOrDefault(z => z._Id==id);
        }
       
        IEnumerable<Zona> IRepositorioZona.ObtenerTodos()
        {
            return _appContext.Zonas;
        }
    }
}