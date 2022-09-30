using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioArea
    {
        Area Agregar(Area areaNuevo); //Me devuelve el cliente
        Area Modificar(Area areaActualizar);
        void Eliminar(int id);
        Area ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Area> ObtenerTodos();


    }
}