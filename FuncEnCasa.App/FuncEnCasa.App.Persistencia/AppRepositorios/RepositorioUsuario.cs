using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly AppContext _appContext;

        public RepositorioUsuario(AppContext contexto)
        {
            _appContext=contexto;
        }
        Usuario IRepositorioUsuario.Agregar(Usuario usuarioNuevo)
        {
            var usuario=_appContext.Usuarios.FirstOrDefault(u => u._Id==usuarioNuevo._Id);
            if(usuario==null)
            {
                var usuarioA=_appContext.Usuarios.Add(usuarioNuevo);
                _appContext.SaveChanges();
                return usuarioA.Entity;
            }
            return usuario;
            
        }
        Usuario IRepositorioUsuario.Modificar(Usuario usuarioActualizar)
        {
            var UsuarioM=_appContext.Usuarios.FirstOrDefault(u => u._Id==usuarioActualizar._Id);
            if(UsuarioM!=null)
            {
                
                _appContext.SaveChanges();
            }
            return UsuarioM;
        }
        void IRepositorioUsuario.Eliminar(int id)
        {
            var UsuarioB=_appContext.Usuarios.FirstOrDefault(u => u._Id==id);
            if (UsuarioB !=null)
            {
                _appContext.Usuarios.Remove(UsuarioB);
                _appContext.SaveChanges();
            }
        }
        Usuario IRepositorioUsuario.ObtenerId(int id)
        {
            return _appContext.Usuarios.FirstOrDefault(u => u._Id==id);
        }
       
        IEnumerable<Usuario> IRepositorioUsuario.ObtenerTodos()
        {
            return _appContext.Usuarios;
        }
    }
}