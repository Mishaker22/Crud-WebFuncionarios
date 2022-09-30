using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace FuncEnCasa.App.Dominio

{
    public class Zona_Localidad
    {
      [Key] 
      [Column("IdZonaSector")]
      public int _Id{get;set;}

      public int? zonaId{get;set;}
      public Zona zona{get;set;}

      public int? sectorId{get;set;}
      public Sector sector{get;set;}

      //listas
      public List<Barrio_ZonaLocalidad> barrioZonaSector{get;set;}//de barrio localidad zona
    }
}