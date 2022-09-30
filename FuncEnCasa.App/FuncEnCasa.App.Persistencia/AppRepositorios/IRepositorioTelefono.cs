
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioTelefono
    {
        Telefono Agregar(Telefono telefonoNuevo); //Me devuelve el cliente
        Telefono Modificar(Telefono telefonoActualizar);
        void Eliminar(int id);
        Telefono ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Telefono> ObtenerTodos();


    }
}