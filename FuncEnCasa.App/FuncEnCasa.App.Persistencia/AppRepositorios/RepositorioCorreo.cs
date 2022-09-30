using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioCorreo : IRepositorioCorreo
    {
        private readonly AppContext _appContext;

        public RepositorioCorreo(AppContext contexto)
        {
            _appContext=contexto;
        }
        Correo IRepositorioCorreo.Agregar(Correo correoNuevo)
        {
            var correo=_appContext.Correos.FirstOrDefault(c => c._Id==correoNuevo._Id);
            if (correo==null)
            {
                var correoA=_appContext.Correos.Add(correoNuevo);
                _appContext.SaveChanges();
                return correoA.Entity;
            }
            return correo;
            
        }
        Correo IRepositorioCorreo.Modificar(Correo correoActualizar)
        {
            var correoM=_appContext.Correos.FirstOrDefault(c => c._Id==correoActualizar._Id);
            if(correoM!=null)
            {
                correoM.correo=correoActualizar.correo;
                _appContext.SaveChanges();
            }
            return correoM;
        }
        void IRepositorioCorreo.Eliminar(int id)
        {
            var correoB=_appContext.Correos.FirstOrDefault(c => c._Id==id);
            if (correoB !=null)
            {
                _appContext.Correos.Remove(correoB);
                _appContext.SaveChanges();
            }
        }
        Correo IRepositorioCorreo.ObtenerId(int id)
        {
            return _appContext.Correos.FirstOrDefault(c => c._Id==id);
        }
       
        IEnumerable<Correo> IRepositorioCorreo.ObtenerTodos()
        {
            return _appContext.Correos;
        }
    }
}