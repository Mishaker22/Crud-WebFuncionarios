using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class Repositorio_TipoViviendaBarrio : IRepositorio_TipoViviendaBarrio
    {
        private readonly AppContext _appContext;

        public Repositorio_TipoViviendaBarrio(AppContext contexto)
        {
            _appContext=contexto;
        }
        TipoVivienda_Barrio IRepositorio_TipoViviendaBarrio.Agregar(TipoVivienda_Barrio tipoViviendaBNuevo)
        {
            var tipoViviendaBA=_appContext.TipoVivienda_Barrios.Add(tipoViviendaBNuevo);
            _appContext.SaveChanges();
            return tipoViviendaBA.Entity;
        }
        TipoVivienda_Barrio IRepositorio_TipoViviendaBarrio.Modificar(TipoVivienda_Barrio tipoViviendaBActualizar)
        {
            var tipoViviendaBM=_appContext.TipoVivienda_Barrios.FirstOrDefault(a => a._Id==tipoViviendaBActualizar._Id);
            if(tipoViviendaBM!=null)
            {
                tipoViviendaBM.direccion=tipoViviendaBActualizar.direccion;
                tipoViviendaBM.ciudadBId=tipoViviendaBActualizar.ciudadBId;
                tipoViviendaBM.tipoViViendaId=tipoViviendaBActualizar.tipoViViendaId;
                _appContext.SaveChanges();
            }
            return tipoViviendaBM;
        }
        void IRepositorio_TipoViviendaBarrio.Eliminar(int id)
        {
            var TipoViviendaBB=_appContext.TipoVivienda_Barrios.FirstOrDefault(a => a._Id==id);
            if (TipoViviendaBB !=null)
            {
                _appContext.TipoVivienda_Barrios.Remove(TipoViviendaBB);
                _appContext.SaveChanges();
            }
        }
        TipoVivienda_Barrio IRepositorio_TipoViviendaBarrio.ObtenerId(int id)
        {
            return _appContext.TipoVivienda_Barrios.FirstOrDefault(a => a._Id==id);
        }
       
        IEnumerable<TipoVivienda_Barrio> IRepositorio_TipoViviendaBarrio.ObtenerTodos()
        {
            return _appContext.TipoVivienda_Barrios;
        }
    }
}