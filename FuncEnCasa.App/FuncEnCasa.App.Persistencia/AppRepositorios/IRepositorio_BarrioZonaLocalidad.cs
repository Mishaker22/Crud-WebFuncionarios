using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorio_BarrioZonaLocalidad
    {
        Barrio_ZonaLocalidad Agregar(Barrio_ZonaLocalidad barrio_ZonaLocalidadNuevo); //Me devuelve el cliente
        Barrio_ZonaLocalidad Modificar(Barrio_ZonaLocalidad barrio_ZonaLocalidadActualizar);
        void Eliminar(int id);
        Barrio_ZonaLocalidad ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Barrio_ZonaLocalidad> ObtenerTodos();


    }
}