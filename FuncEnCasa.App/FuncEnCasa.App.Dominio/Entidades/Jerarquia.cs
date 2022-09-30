using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Jerarquia
    {
      [Key] 
      [Column("IdJerarquia")]
      public int _Id{get;set;}
      [MaxLength(50)]
      [Required]
      public string nombreJerarquia {get;set;}

    
    }
}