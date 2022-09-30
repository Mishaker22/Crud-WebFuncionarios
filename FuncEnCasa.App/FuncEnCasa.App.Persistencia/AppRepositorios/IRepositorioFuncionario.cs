using System.Collections.Generic;
using FuncEnCasa.App.Dominio;

namespace FuncEnCasa.App.Persistencia
{
    public interface IRepositorioFuncionario
    {
        Funcionario Agregar(Funcionario funcionarioNueva); //Me devuelve el cliente
        Funcionario Modificar(Funcionario funcionarioActualizar);
        void Eliminar(int id);
        Funcionario ObtenerId(int id);
        // IEnumerable ->List
        IEnumerable<Funcionario> ObtenerTodos();
    }
}