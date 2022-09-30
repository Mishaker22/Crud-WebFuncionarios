using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class Repositorio_TelefonoUsuario : IRepositorio_TelefonoUsuario
    {
        private readonly AppContext _appContext;

        public Repositorio_TelefonoUsuario(AppContext contexto)
        {
            _appContext=contexto;
        }
        Telefono_Usuario IRepositorio_TelefonoUsuario.Agregar(Telefono_Usuario telefonoUNuevo)
        {
            var telefonoUA=_appContext.TelefonoUsuarios.Add(telefonoUNuevo);
            _appContext.SaveChanges();
            return telefonoUA.Entity;
        }
        Telefono_Usuario IRepositorio_TelefonoUsuario.Modificar(Telefono_Usuario telefonoUActualizar)
        {
            var telefonoUM=_appContext.TelefonoUsuarios.FirstOrDefault(a => a._Id==telefonoUActualizar._Id);
            if(telefonoUM!=null)
            {
                telefonoUM.TelefonoId=telefonoUActualizar.TelefonoId;
                telefonoUM.UsuarioId=telefonoUActualizar.UsuarioId;
                _appContext.SaveChanges();
            }
            return telefonoUM;
        }
        void IRepositorio_TelefonoUsuario.Eliminar(int id)
        {
            var telefonoUB=_appContext.TelefonoUsuarios.FirstOrDefault(a => a._Id==id);
            if (telefonoUB !=null)
            {
                _appContext.TelefonoUsuarios.Remove(telefonoUB);
                _appContext.SaveChanges();
            }
        }
        Telefono_Usuario IRepositorio_TelefonoUsuario.ObtenerId(int id)
        {
            return _appContext.TelefonoUsuarios.FirstOrDefault(a => a._Id==id);
        }
       
        IEnumerable<Telefono_Usuario> IRepositorio_TelefonoUsuario.ObtenerTodos()
        {
            return _appContext.TelefonoUsuarios;
        }
    }
}