using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorio_PaisDepartamento
    {
        Pais_Departamento Agregar(Pais_Departamento pais_DepartamentoNuevo); //Me devuelve el cliente
        Pais_Departamento Modificar(Pais_Departamento pais_DepartamentoActualizar);
        void Eliminar(int id);
        Pais_Departamento ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Pais_Departamento> ObtenerTodos();


    }
}