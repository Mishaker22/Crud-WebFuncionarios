using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Telefono
    {
      [Key] 
      [Column("IdTelefono")]
      public int _Id{get;set;}

      [Required]
      public long numeroTel {get;set;}
    
      //listas
      public List<Telefono_Usuario> usuario{get;set;}
      public List<Funcionario> funcionario{get;set;}// de funcionarios
    }
}