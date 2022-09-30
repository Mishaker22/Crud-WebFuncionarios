
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioSucursal
    {
        Sucursal Agregar(Sucursal sucursalNueva); //Me devuelve el cliente
        Sucursal Modificar(Sucursal sucursalActualizar);
        void Eliminar(int id);
        Sucursal ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Sucursal> ObtenerTodos();


    }
}