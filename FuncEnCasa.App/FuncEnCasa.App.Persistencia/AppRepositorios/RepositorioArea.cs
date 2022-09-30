using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioArea : IRepositorioArea
    {
        private readonly AppContext _appContext;

        public RepositorioArea(AppContext contexto)
        {
            _appContext=contexto;
        }
        Area IRepositorioArea.Agregar(Area areaNuevo)
        {
            var areaA=_appContext.Areas.Add(areaNuevo);
            _appContext.SaveChanges();
            return areaA.Entity;
        }
        Area IRepositorioArea.Modificar(Area areaActualizar)
        {
            var areaM=_appContext.Areas.FirstOrDefault(a => a._Id==areaActualizar._Id);
            if(areaM!=null)
            {
                areaM.nombreArea=areaActualizar.nombreArea;
                _appContext.SaveChanges();
            }
            return areaM;
        }
        void IRepositorioArea.Eliminar(int id)
        {
            var areaB=_appContext.Areas.FirstOrDefault(a => a._Id==id);
            if (areaB !=null)
            {
                _appContext.Areas.Remove(areaB);
                _appContext.SaveChanges();
            }
        }
        Area IRepositorioArea.ObtenerId(int id)
        {
            return _appContext.Areas.FirstOrDefault(a => a._Id==id);
        }
       
        IEnumerable<Area> IRepositorioArea.ObtenerTodos()
        {
            return _appContext.Areas;
        }
    }
}