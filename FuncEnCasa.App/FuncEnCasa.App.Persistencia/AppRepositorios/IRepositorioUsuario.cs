
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        Usuario Agregar(Usuario usuarioNueva); //Me devuelve el cliente
        Usuario Modificar(Usuario usuarioActualizar);
        void Eliminar(int id);
        Usuario ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Usuario> ObtenerTodos();


    }
}