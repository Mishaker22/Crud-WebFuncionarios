
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioTipoVivienda
    {
        TipoVivienda Agregar(TipoVivienda tipoViviendaNuevo); //Me devuelve el cliente
        TipoVivienda Modificar(TipoVivienda tipoViviendaActualizar);
        void Eliminar(int id);
        TipoVivienda ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<TipoVivienda> ObtenerTodos();
    }
}