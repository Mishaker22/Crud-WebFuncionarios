
using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioDepartamento
    {
        Departamento Agregar(Departamento departamentoNuevo); //Me devuelve el cliente
        Departamento Modificar(Departamento departamentoActualizar);
        void Eliminar(int id);
        Departamento ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Departamento> ObtenerTodos();


    }
}