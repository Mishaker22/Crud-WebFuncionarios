using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Sucursal
    {
      [Key] 
      [Column("IdSucursal")]
      public int _Id{get;set;}
      [MaxLength(50)]
      [Required]
      public string nombreSucursal {get;set;}

      public int? ciudadId{get;set;}
      public Ciudad ciudad{get;set;}
   
      //listas
      public List<Funcionario> funcionario{get;set;}
    }
}