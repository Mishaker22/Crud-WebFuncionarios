using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{ 
    public class Ciudad_BarrioZonaLocalidad
    {
      [Key] 
      [Column("IdCiudadBZL")]
      public int _Id{get;set;}

      public int? ciudadId{get;set;}
      public Ciudad ciudad{get;set;}

      public int? BarrioZLId{get;set;}
      public Barrio_ZonaLocalidad barrioZL{get;set;}

      //listas
      //public Barrio_ZonaLocalidad barrio_ZonaLocalidad{get;set;}
      public List<TipoVivienda_Barrio> TipoViviendaBarrio{get;set;}//de tipo de viviendaBarrio
      
    }
}