using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioBarrio : IRepositorioBarrio
    {
        private readonly AppContext _appContext;

        public RepositorioBarrio(AppContext contexto)
        {
            _appContext=contexto;
        }
        Barrio IRepositorioBarrio.Agregar(Barrio barrioNuevo)
        {
            var barrioA=_appContext.Barrios.Add(barrioNuevo);
            _appContext.SaveChanges();
            return barrioA.Entity;
        }
        Barrio IRepositorioBarrio.Modificar(Barrio barrioActualizar)
        {
            var barrioM=_appContext.Barrios.FirstOrDefault(b => b._Id==barrioActualizar._Id);
            if(barrioM!=null)
            {
                barrioM.nombreBarrio=barrioActualizar.nombreBarrio;
                _appContext.SaveChanges();
            }
            return barrioM;
        }
        void IRepositorioBarrio.Eliminar(int id)
        {
            var barrioB=_appContext.Barrios.FirstOrDefault(b => b._Id==id);
            if (barrioB !=null)
            {
                _appContext.Barrios.Remove(barrioB);
                _appContext.SaveChanges();
            }
        }
        Barrio IRepositorioBarrio.ObtenerId(int id)
        {
            return _appContext.Barrios.FirstOrDefault(b => b._Id==id);
        }
       
        IEnumerable<Barrio> IRepositorioBarrio.ObtenerTodos()
        {
            return _appContext.Barrios;
        }
    }
}