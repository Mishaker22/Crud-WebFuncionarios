using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioPais
    {
        Pais Agregar(Pais paisNuevo); //Me devuelve el cliente
        Pais Modificar(Pais paisActualizar);
        void Eliminar(int id);
        Pais ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Pais> ObtenerTodos();


    }
}