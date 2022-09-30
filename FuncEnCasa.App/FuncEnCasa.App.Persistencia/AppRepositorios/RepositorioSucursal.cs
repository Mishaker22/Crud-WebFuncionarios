using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioSucursal : IRepositorioSucursal
    {
        private readonly AppContext _appContext;

        public RepositorioSucursal(AppContext contexto)
        {
            _appContext=contexto;
        }
        Sucursal IRepositorioSucursal.Agregar(Sucursal sucursalNueva)
        {
            var sucursalA=_appContext.Sucursales.Add(sucursalNueva);
            _appContext.SaveChanges();
            return sucursalA.Entity;
        }
        Sucursal IRepositorioSucursal.Modificar(Sucursal sucursalActualizar)
        {
            var sucursalM=_appContext.Sucursales.FirstOrDefault(s => s._Id==sucursalActualizar._Id);
            if(sucursalM!=null)
            {
                sucursalM.nombreSucursal=sucursalActualizar.nombreSucursal;
                sucursalM.ciudadId=sucursalActualizar.ciudadId;
                _appContext.SaveChanges();
            }
            return sucursalM;
        }
        void IRepositorioSucursal.Eliminar(int id)
        {
            var sucursalB=_appContext.Sucursales.FirstOrDefault(s => s._Id==id);
            if (sucursalB !=null)
            {
                _appContext.Sucursales.Remove(sucursalB);
                _appContext.SaveChanges();
            }
        }
        Sucursal IRepositorioSucursal.ObtenerId(int id)
        {
            return _appContext.Sucursales.FirstOrDefault(s => s._Id==id);
        }
       
        IEnumerable<Sucursal> IRepositorioSucursal.ObtenerTodos()
        {
            return _appContext.Sucursales;
        }
    }
}