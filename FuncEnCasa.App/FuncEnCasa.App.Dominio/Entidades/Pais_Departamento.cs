using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FuncEnCasa.App.Dominio

{
    public class Pais_Departamento
    {
      [Key] 
      [Column("IdDepartamentoPais")]
      public int _Id{get;set;}

      public int? paisId {get;set;}
      public Pais pais{get;set;}

      public int? departamentoId {get;set;}
      public Departamento departamento {get;set;}

   
    }
}