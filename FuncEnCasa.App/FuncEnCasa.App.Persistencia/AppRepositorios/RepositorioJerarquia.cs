using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioJerarquia : IRepositorioJerarquia
    {
        private readonly AppContext _appContext;

        public RepositorioJerarquia(AppContext contexto)
        {
            _appContext=contexto;
        }
        Jerarquia IRepositorioJerarquia.Agregar(Jerarquia jerarquiaNueva)
        {
            var JerarquiaA=_appContext.Jerarquias.Add(jerarquiaNueva);
            _appContext.SaveChanges();
            return JerarquiaA.Entity;
        }
        Jerarquia IRepositorioJerarquia.Modificar(Jerarquia jerarquiaActualizar)
        {
            var JerarquiaM=_appContext.Jerarquias.FirstOrDefault(j => j._Id==jerarquiaActualizar._Id);
            if(JerarquiaM!=null)
            {
                JerarquiaM.nombreJerarquia=jerarquiaActualizar.nombreJerarquia;
                _appContext.SaveChanges();
            }
            return JerarquiaM;
        }
        void IRepositorioJerarquia.Eliminar(int id)
        {
            var JerarquiaB=_appContext.Jerarquias.FirstOrDefault(j => j._Id==id);
            if (JerarquiaB !=null)
            {
                _appContext.Jerarquias.Remove(JerarquiaB);
                _appContext.SaveChanges();
            }
        }
        Jerarquia IRepositorioJerarquia.ObtenerId(int id)
        {
            return _appContext.Jerarquias.FirstOrDefault(j => j._Id==id);
        }
       
        IEnumerable<Jerarquia> IRepositorioJerarquia.ObtenerTodos()
        {
            return _appContext.Jerarquias;
        }
    }
}