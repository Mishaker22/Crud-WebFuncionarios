using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Correo
    {
      [Key] 
      [Column("IdCorreo")]
      public int _Id{get;set;}

      [Required]
      public string correo {get;set;}

      //listas
      public List<Correo_Usuario> correoUsuario{get;set;}
      public List<Funcionario> funcionario{get;set;}// de funcionarios
    }
}