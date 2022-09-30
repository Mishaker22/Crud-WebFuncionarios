using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioTipoVivienda : IRepositorioTipoVivienda
    {
        private readonly AppContext _appContext;

        public RepositorioTipoVivienda(AppContext contexto)
        {
            _appContext=contexto;
        }
        TipoVivienda IRepositorioTipoVivienda.Agregar(TipoVivienda tipoViNueva)
        {
            var tipoViA=_appContext.TipoViviendas.Add(tipoViNueva);
            _appContext.SaveChanges();
            return tipoViA.Entity;
        }
        TipoVivienda IRepositorioTipoVivienda.Modificar(TipoVivienda tipoViActualizar)
        {
            var tipoViM=_appContext.TipoViviendas.FirstOrDefault(t => t._Id==tipoViActualizar._Id);
            if(tipoViM!=null)
            {
                tipoViM.descripcion=tipoViActualizar.descripcion;
               
                _appContext.SaveChanges();
            }
            return tipoViM;
        }
        void IRepositorioTipoVivienda.Eliminar(int id)
        {
            var telB=_appContext.TipoViviendas.FirstOrDefault(t => t._Id==id);
            if (telB !=null)
            {
                _appContext.TipoViviendas.Remove(telB);
                _appContext.SaveChanges();
            }
        }
        TipoVivienda IRepositorioTipoVivienda.ObtenerId(int id)
        {
            return _appContext.TipoViviendas.FirstOrDefault(t => t._Id==id);
        }
       
        IEnumerable<TipoVivienda> IRepositorioTipoVivienda.ObtenerTodos()
        {
            return _appContext.TipoViviendas;
        }
    }
}