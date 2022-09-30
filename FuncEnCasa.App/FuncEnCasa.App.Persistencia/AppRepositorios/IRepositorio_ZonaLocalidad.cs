using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorio_ZonaLocalidad
    {
        Zona_Localidad Agregar(Zona_Localidad zona_LocalidadNuevo); //Me devuelve el cliente
        Zona_Localidad Modificar(Zona_Localidad zona_LocalidadActualizar);
        void Eliminar(int id);
        Zona_Localidad ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Zona_Localidad> ObtenerTodos();


    }
}