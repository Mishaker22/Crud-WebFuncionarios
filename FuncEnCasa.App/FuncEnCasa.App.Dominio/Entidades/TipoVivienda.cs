using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class TipoVivienda
    {
      [Key] 
      [Column("IdTipoViVienda")]
      public int _Id{get;set;}
      [MaxLength(50)]
      [Required]
      public string descripcion {get;set;}

      //listas
      
      public List<TipoVivienda_Barrio> tipoViviendaBarrio{get;set;}//de tipo de viviendaBarrio
    }
}