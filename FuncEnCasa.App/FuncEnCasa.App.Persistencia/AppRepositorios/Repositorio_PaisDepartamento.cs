using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class Repositorio_PaisDepartamento : IRepositorio_PaisDepartamento
    {
        private readonly AppContext _appContext;

        public Repositorio_PaisDepartamento(AppContext contexto)
        {
            _appContext=contexto;
        }
        Pais_Departamento IRepositorio_PaisDepartamento.Agregar(Pais_Departamento paisDNuevo)
        {
            var paisDA=_appContext.Pais_Departamentos.Add(paisDNuevo);
            _appContext.SaveChanges();
            return paisDA.Entity;
        }
        Pais_Departamento IRepositorio_PaisDepartamento.Modificar(Pais_Departamento paisDActualizar)
        {
            var paisDM=_appContext.Pais_Departamentos.FirstOrDefault(a => a._Id==paisDActualizar._Id);
            if(paisDM!=null)
            {
                paisDM.paisId=paisDActualizar.paisId;
                paisDM.departamentoId=paisDActualizar.departamentoId;
                _appContext.SaveChanges();
            }
            return paisDM;
        }
        void IRepositorio_PaisDepartamento.Eliminar(int id)
        {
            var paisDB=_appContext.Pais_Departamentos.FirstOrDefault(a => a._Id==id);
            if (paisDB !=null)
            {
                _appContext.Pais_Departamentos.Remove(paisDB);
                _appContext.SaveChanges();
            }
        }
        Pais_Departamento IRepositorio_PaisDepartamento.ObtenerId(int id)
        {
            return _appContext.Pais_Departamentos.FirstOrDefault(a => a._Id==id);
        }
       
        IEnumerable<Pais_Departamento> IRepositorio_PaisDepartamento.ObtenerTodos()
        {
            return _appContext.Pais_Departamentos;
        }
    }
}