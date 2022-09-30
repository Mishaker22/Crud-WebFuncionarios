using System.Collections.Generic;
using System;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioPais : IRepositorioPais
    {
        private readonly AppContext _appContext;

        public RepositorioPais(AppContext contexto)
        {
            _appContext=contexto;
        }
        Pais IRepositorioPais.Agregar(Pais paisNuevo)
        {
            var paisA=_appContext.Paises.Add(paisNuevo);
            _appContext.SaveChanges();
            return paisA.Entity;
        }
        Pais IRepositorioPais.Modificar(Pais paisActualizar)
        {
            var paisM=_appContext.Paises.FirstOrDefault(p => p._Id==paisActualizar._Id);
            if(paisM!=null)
            {
                paisM.nombrePais=paisActualizar.nombrePais;
                _appContext.SaveChanges();
            }else
            {
                Console.WriteLine("No se pudo encontrar el id ");
            }
            return paisM;
        }
        void IRepositorioPais.Eliminar(int id)
        {
            var paisB=_appContext.Paises.FirstOrDefault(p => p._Id==id);
            if (paisB !=null)
            {
                _appContext.Paises.Remove(paisB);
                _appContext.SaveChanges();
            }else
            {
                Console.WriteLine("No se pudo encontrar el id ");
            }
        }
        Pais IRepositorioPais.ObtenerId(int id)
        {
            return _appContext.Paises.FirstOrDefault(p => p._Id==id);
        }
       
        IEnumerable<Pais> IRepositorioPais.ObtenerTodos()
        {
            return _appContext.Paises;
        }
    }
}