
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioDireccion
    {
        Direccion Agregar(Direccion direccionNueva); 
        Direccion Modificar(Direccion direccionActualizar);
        void Eliminar(int id);
        Direccion ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Direccion> ObtenerTodos();


    }
}