using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioDepartamento : IRepositorioDepartamento
    {
        private readonly AppContext _appContext;

        public RepositorioDepartamento(AppContext contexto)
        {
            _appContext=contexto;
        }
        Departamento IRepositorioDepartamento.Agregar(Departamento departamentoNuevo)
        {
            var departamentoA=_appContext.Departamentos.Add(departamentoNuevo);
            _appContext.SaveChanges();
            return departamentoA.Entity;
        }
        Departamento IRepositorioDepartamento.Modificar(Departamento departamentoActualizar)
        {
            var departamentoM=_appContext.Departamentos.FirstOrDefault(d => d._Id==departamentoActualizar._Id);
            if(departamentoM!=null)
            {
                departamentoM.nombreDepart=departamentoActualizar.nombreDepart;
                _appContext.SaveChanges();
            }
            return departamentoM;
        }
        void IRepositorioDepartamento.Eliminar(int id)
        {
            var departamentoB=_appContext.Departamentos.FirstOrDefault(d => d._Id==id);
            if (departamentoB !=null)
            {
                _appContext.Departamentos.Remove(departamentoB);
                _appContext.SaveChanges();
            }
        }
        Departamento IRepositorioDepartamento.ObtenerId(int id)
        {
            return _appContext.Departamentos.FirstOrDefault(d => d._Id==id);
        }
       
        IEnumerable<Departamento> IRepositorioDepartamento.ObtenerTodos()
        {
            return _appContext.Departamentos;
        }
    }
}