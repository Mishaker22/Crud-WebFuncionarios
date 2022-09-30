
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioSector
    {
        Sector Agregar(Sector sectorNuevo); //Me devuelve el cliente
        Sector Modificar(Sector sectorActualizar);
        void Eliminar(int id);
        Sector ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Sector> ObtenerTodos();


    }
}