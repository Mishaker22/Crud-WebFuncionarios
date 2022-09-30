
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioJerarquia
    {
        Jerarquia Agregar(Jerarquia jerarquiaNuevo); //Me devuelve el cliente
        Jerarquia Modificar(Jerarquia jerarquiaActualizar);
        void Eliminar(int id);
        Jerarquia ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Jerarquia> ObtenerTodos();


    }
}