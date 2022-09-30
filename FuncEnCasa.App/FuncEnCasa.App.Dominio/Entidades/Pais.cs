using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Pais
    {
      [Key] 
      [Column("IdPais")]
      public int _Id{get;set;}
      [MaxLength(50)]
      [Required]
      public string nombrePais {get;set;}
      //Lista de departamentos
      public List<Pais_Departamento> paisDepartamentos{get;set;}

    }
}