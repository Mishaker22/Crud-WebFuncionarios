
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioZona
    {
        Zona Agregar(Zona zonaNuevo); //Me devuelve el cliente
        Zona Modificar(Zona zonaActualizar);
        void Eliminar(int id);
        Zona ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Zona> ObtenerTodos();
    }
}