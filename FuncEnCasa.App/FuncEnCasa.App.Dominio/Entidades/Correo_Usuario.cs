using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Correo_Usuario
    {
      [Key] 
      [Column("IdCorreoU")]
      public int _Id{get;set;}

      public TipoContacto idTipoContacto{get;set;}

      public int? CorreoId{get;set;}
      public Correo correo{get;set;}

      public int? UsuarioId {get;set;}
      public Usuario usuario{get;set;}


    }
}