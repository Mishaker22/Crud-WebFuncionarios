using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorio_CiudadDepartamento
    {
        Ciudad_Departamento Agregar(Ciudad_Departamento ciudad_DepartamentoNuevo); //Me devuelve el cliente
        Ciudad_Departamento Modificar(Ciudad_Departamento ciudad_DepartamentoActualizar);
        void Eliminar(int id);
        Ciudad_Departamento ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Ciudad_Departamento> ObtenerTodos();


    }
}