using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorio_CiudadBarrioZonaLocalidad
    {
        Ciudad_BarrioZonaLocalidad Agregar(Ciudad_BarrioZonaLocalidad ciudad_BarrioZonaLocalidadNuevo); //Me devuelve el cliente
        Ciudad_BarrioZonaLocalidad Modificar(Ciudad_BarrioZonaLocalidad ciudad_BarrioZonaLocalidadActualizar);
        void Eliminar(int id);
        Ciudad_BarrioZonaLocalidad ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Ciudad_BarrioZonaLocalidad> ObtenerTodos();


    }
}