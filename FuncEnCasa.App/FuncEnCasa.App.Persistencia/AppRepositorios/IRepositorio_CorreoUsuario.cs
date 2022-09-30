using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorio_CorreoUsuario
    {
        Correo_Usuario Agregar(Correo_Usuario correo_UsuarioNuevo); //Me devuelve el cliente
        Correo_Usuario Modificar(Correo_Usuario correo_UsuarioActualizar);
        void Eliminar(int id);
        Correo_Usuario ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Correo_Usuario> ObtenerTodos();


    }
}