
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioBarrio
    {
        Barrio Agregar(Barrio barrioNuevo); //Me devuelve el cliente
        Barrio Modificar(Barrio barrioActualizar);
        void Eliminar(int id);
        Barrio ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Barrio> ObtenerTodos();


    }
}