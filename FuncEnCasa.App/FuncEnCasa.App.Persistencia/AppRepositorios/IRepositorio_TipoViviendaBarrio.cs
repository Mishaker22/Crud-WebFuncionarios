using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorio_TipoViviendaBarrio
    {
        TipoVivienda_Barrio Agregar(TipoVivienda_Barrio tipoVivienda_BarrioNuevo); //Me devuelve el cliente
        TipoVivienda_Barrio Modificar(TipoVivienda_Barrio tipoVivienda_BarrioActualizar);
        void Eliminar(int id);
        TipoVivienda_Barrio ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<TipoVivienda_Barrio> ObtenerTodos();


    }
}