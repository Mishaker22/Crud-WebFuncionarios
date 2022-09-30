using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Sector
    {
      [Key] 
      [Column("IdSector")]
      public int _Id{get;set;}
      [MaxLength(50)]
      [Required]
      public string nombreSector {get;set;}
      //listas
      public List<Zona_Localidad> zonaLocalidad{get;set;}//llave zonasector
    }
}