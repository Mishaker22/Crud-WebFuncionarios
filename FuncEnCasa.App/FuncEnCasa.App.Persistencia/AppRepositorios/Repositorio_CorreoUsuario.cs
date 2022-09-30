using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class Repositorio_CorreoUsuario : IRepositorio_CorreoUsuario
    {
        private readonly AppContext _appContext;

        public Repositorio_CorreoUsuario(AppContext contexto)
        {
            _appContext=contexto;
        }
        Correo_Usuario IRepositorio_CorreoUsuario.Agregar(Correo_Usuario correoUNuevo)
        {
            var correoUA=_appContext.CorreoUsuarios.Add(correoUNuevo);
            _appContext.SaveChanges();
            return correoUA.Entity;
        }
        Correo_Usuario IRepositorio_CorreoUsuario.Modificar(Correo_Usuario correoUActualizar)
        {
            var correoUM=_appContext.CorreoUsuarios.FirstOrDefault(a => a._Id==correoUActualizar._Id);
            if(correoUM!=null)
            {
                correoUM.CorreoId=correoUActualizar.CorreoId;
                correoUM.UsuarioId=correoUActualizar.UsuarioId;
                _appContext.SaveChanges();
            }
            return correoUM;
        }
        void IRepositorio_CorreoUsuario.Eliminar(int id)
        {
            var correoUB=_appContext.CorreoUsuarios.FirstOrDefault(a => a._Id==id);
            if (correoUB !=null)
            {
                _appContext.CorreoUsuarios.Remove(correoUB);
                _appContext.SaveChanges();
            }
        }
        Correo_Usuario IRepositorio_CorreoUsuario.ObtenerId(int id)
        {
            return _appContext.CorreoUsuarios.FirstOrDefault(a => a._Id==id);
        }
       
        IEnumerable<Correo_Usuario> IRepositorio_CorreoUsuario.ObtenerTodos()
        {
            return _appContext.CorreoUsuarios;
        }
    }
}