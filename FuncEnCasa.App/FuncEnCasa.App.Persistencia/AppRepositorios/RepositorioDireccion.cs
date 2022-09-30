using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioDireccion : IRepositorioDireccion
    {
        private readonly AppContext _appContext;

        public RepositorioDireccion(AppContext contexto)
        {
            _appContext=contexto;
        }
        Direccion IRepositorioDireccion.Agregar(Direccion direccionNueva)
        {
            var direccionA=_appContext.Direcciones.Add(direccionNueva);
            _appContext.SaveChanges();
            return direccionA.Entity;
        }
        Direccion IRepositorioDireccion.Modificar(Direccion direccionActualizar)
        {
            var direccionM=_appContext.Direcciones.FirstOrDefault(d => d._Id==direccionActualizar._Id);
            if(direccionM!=null)
            {
                direccionM.direccion=direccionActualizar.direccion;
                direccionM.tipoViviendaBId = direccionActualizar.tipoViviendaBId; 
                _appContext.SaveChanges();
            }
            return direccionM;
        }
        void IRepositorioDireccion.Eliminar(int id)
        {
            var direccionB=_appContext.Direcciones.FirstOrDefault(d => d._Id==id);
            if (direccionB !=null)
            {
                _appContext.Direcciones.Remove(direccionB);
                _appContext.SaveChanges();
            }
        }
        Direccion IRepositorioDireccion.ObtenerId(int id)
        {
            return _appContext.Direcciones.FirstOrDefault(d => d._Id==id);
        }
       
        IEnumerable<Direccion> IRepositorioDireccion.ObtenerTodos()
        {
            return _appContext.Direcciones;
        }
    }
}