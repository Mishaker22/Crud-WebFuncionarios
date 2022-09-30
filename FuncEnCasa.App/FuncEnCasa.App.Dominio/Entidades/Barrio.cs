using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Barrio
    {
      [Key] 
      [Column("IdBarrio")]
      public int _Id{get;set;}
      [MaxLength(50)]
      [Required]
      public string nombreBarrio {get;set;}

      //listas
      public List<Barrio_ZonaLocalidad> barrioZonaSector{get;set;}//de barrio localidad zona
      
    }
}