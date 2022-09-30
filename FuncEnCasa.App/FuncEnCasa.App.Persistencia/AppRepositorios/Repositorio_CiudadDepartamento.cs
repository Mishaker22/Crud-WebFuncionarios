using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class Repositorio_CiudadDepartamento : IRepositorio_CiudadDepartamento
    {
        private readonly AppContext _appContext;

        public Repositorio_CiudadDepartamento(AppContext contexto)
        {
            _appContext=contexto;
        }
        Ciudad_Departamento IRepositorio_CiudadDepartamento.Agregar(Ciudad_Departamento ciudadDNuevo)
        {
            var ciudadDA=_appContext.Ciudad_Departamentos.Add(ciudadDNuevo);
            _appContext.SaveChanges();
            return ciudadDA.Entity;
        }
        Ciudad_Departamento IRepositorio_CiudadDepartamento.Modificar(Ciudad_Departamento ciudadDActualizar)
        {
            var ciudadDM=_appContext.Ciudad_Departamentos.FirstOrDefault(a => a._Id==ciudadDActualizar._Id);
            if(ciudadDM!=null)
            {
                ciudadDM.ciudadId =ciudadDActualizar.ciudadId ;
                ciudadDM.departamentoId =ciudadDActualizar.departamentoId ;
                _appContext.SaveChanges();
            }
            return ciudadDM;
        }
        void IRepositorio_CiudadDepartamento.Eliminar(int id)
        {
            var ciudadDB=_appContext.Ciudad_Departamentos.FirstOrDefault(a => a._Id==id);
            if (ciudadDB !=null)
            {
                _appContext.Ciudad_Departamentos.Remove(ciudadDB);
                _appContext.SaveChanges();
            }
        }
        Ciudad_Departamento IRepositorio_CiudadDepartamento.ObtenerId(int id)
        {
            return _appContext.Ciudad_Departamentos.FirstOrDefault(a => a._Id==id);
        }
       
        IEnumerable<Ciudad_Departamento> IRepositorio_CiudadDepartamento.ObtenerTodos()
        {
            return _appContext.Ciudad_Departamentos;
        }
    }
}