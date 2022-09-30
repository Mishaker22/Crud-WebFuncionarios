using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Telefono_Usuario
    {
      [Key] 
      [Column("IdTelefonoU")]
      public int _Id{get;set;}

      public TipoContacto idTipoContacto{get;set;}

      public int? TelefonoId{get;set;}
      public Telefono telefono{get;set;}

      public int? UsuarioId {get;set;}
      public Usuario usuario{get;set;}

    }
}