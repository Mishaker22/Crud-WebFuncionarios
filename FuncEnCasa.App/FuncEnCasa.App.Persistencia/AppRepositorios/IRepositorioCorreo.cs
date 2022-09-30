using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioCorreo
    {
        Correo Agregar(Correo correoNuevo); //Me devuelve el cliente
        Correo Modificar(Correo correoActualizar);
        void Eliminar(int id);
        Correo ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Correo> ObtenerTodos();


    }
}