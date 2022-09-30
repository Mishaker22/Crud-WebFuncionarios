using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioTelefono : IRepositorioTelefono
    {
        private readonly AppContext _appContext;

        public RepositorioTelefono(AppContext contexto)
        {
            _appContext=contexto;
        }
        Telefono IRepositorioTelefono.Agregar(Telefono telNuevo)
        {
            var telefono=_appContext.Telefonos.FirstOrDefault(t => t._Id==telNuevo._Id);
            if (telefono==null)
            {
                var telA=_appContext.Telefonos.Add(telNuevo);
                _appContext.SaveChanges();
                return telA.Entity;
            }
            return telefono; 
        }
        Telefono IRepositorioTelefono.Modificar(Telefono telActualizar)
        {
            var telM=_appContext.Telefonos.FirstOrDefault(t => t._Id==telActualizar._Id);
            if(telM!=null)
            {
                telM.numeroTel=telActualizar.numeroTel;
                _appContext.SaveChanges();
            }
            return telM;
        }
        void IRepositorioTelefono.Eliminar(int id)
        {
            var telB=_appContext.Telefonos.FirstOrDefault(t => t._Id==id);
            if (telB !=null)
            {
                _appContext.Telefonos.Remove(telB);
                _appContext.SaveChanges();
            }
        }
        Telefono IRepositorioTelefono.ObtenerId(int id)
        {
            return _appContext.Telefonos.FirstOrDefault(t => t._Id==id);
        }
       
        IEnumerable<Telefono> IRepositorioTelefono.ObtenerTodos()
        {
            return _appContext.Telefonos;
        }
    }
}