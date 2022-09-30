using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioCiudad : IRepositorioCiudad
    {
        private readonly AppContext _appContext;

        public RepositorioCiudad(AppContext contexto)
        {
            _appContext=contexto;
        }
        Ciudad IRepositorioCiudad.Agregar(Ciudad ciudadNuevo)
        {
            var ciudadA=_appContext.Ciudades.Add(ciudadNuevo);
            _appContext.SaveChanges();
            return ciudadA.Entity;
        }
        Ciudad IRepositorioCiudad.Modificar(Ciudad ciudadActualizar)
        {
            var ciudadM=_appContext.Ciudades.FirstOrDefault(c => c._Id==ciudadActualizar._Id);
            if(ciudadM!=null)
            {
                ciudadM.nombreCiudad=ciudadActualizar.nombreCiudad;
                _appContext.SaveChanges();
            }
            return ciudadM;
        }
        void IRepositorioCiudad.Eliminar(int id)
        {
            var ciudadB=_appContext.Ciudades.FirstOrDefault(c => c._Id==id);
            if (ciudadB !=null)
            {
                _appContext.Ciudades.Remove(ciudadB);
                _appContext.SaveChanges();
            }
        }
        Ciudad IRepositorioCiudad.ObtenerId(int id)
        {
            return _appContext.Ciudades.FirstOrDefault(c => c._Id==id);
        }
       
        IEnumerable<Ciudad> IRepositorioCiudad.ObtenerTodos()
        {
            return _appContext.Ciudades;
        }
    }
}