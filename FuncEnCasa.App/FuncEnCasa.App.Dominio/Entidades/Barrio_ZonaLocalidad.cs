using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Barrio_ZonaLocalidad
    {
      [Key] 
      [Column("IdBarrioZL")]
      public int _Id{get;set;}

      public int? barrioId{get;set;}
      public Barrio barrio{get;set;}

      public int? ZonaLId {get;set;}
      public Zona_Localidad zonaL{get;set;}

      //listas
      public List<Ciudad_BarrioZonaLocalidad> ciudadBarrioZonaLocalidad{get;set;}//de CiudadBarrioZonaSector


    
    }
}