using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Usuario
    {
      [Key] 
      [Column("IdUsuario")]
      public int _Id{get;set;}
      //listas
      public List<Funcionario> funcionario{get;set;}

    }
}