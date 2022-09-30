using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class TipoVivienda_Barrio
    {
      [Key] 
      [Column("IdTipoViviendaB")]
      public int _Id{get;set;}

      public int? ciudadBId{get;set;}
      public Ciudad_BarrioZonaLocalidad ciudadB {get;set;}

      public int? tipoViViendaId {get;set;}
      public TipoVivienda tipoVivienda {get;set;}

      //listas
      public List<Direccion> direccion{get;set;} //de Direccion
    }
}