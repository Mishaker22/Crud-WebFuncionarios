using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioCiudad
    {
        Ciudad Agregar(Ciudad ciudadNuevo); //Me devuelve el cliente
        Ciudad Modificar(Ciudad ciudadActualizar);
        void Eliminar(int id);
        Ciudad ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Ciudad> ObtenerTodos();


    }
}