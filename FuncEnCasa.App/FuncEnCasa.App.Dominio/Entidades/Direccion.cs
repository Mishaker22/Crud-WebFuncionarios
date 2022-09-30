using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Direccion
    {
      [Key] 
      [Column("IdDireccion")]
      public int _Id{get;set;}

      [MaxLength(50)]
      [Required]
      public string direccion{get;set;}

      public int? tipoViviendaBId {get;set;}
      public TipoVivienda_Barrio tipoViviendaB {get;set;}

      //listas
      public List<Funcionario> funcionario{get;set;}
    }
}