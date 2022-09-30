using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorio_TelefonoUsuario
    {
        Telefono_Usuario Agregar(Telefono_Usuario telefono_UsuarioNuevo); //Me devuelve el cliente
        Telefono_Usuario Modificar(Telefono_Usuario telefono_UsuarioActualizar);
        void Eliminar(int id);
        Telefono_Usuario ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Telefono_Usuario> ObtenerTodos();


    }
}