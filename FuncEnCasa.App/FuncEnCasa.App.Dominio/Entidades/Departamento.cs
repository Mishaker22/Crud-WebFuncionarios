using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Departamento
    {
      [Key] 
      [Column("IdDepartamento")]
      public int _Id{get;set;}
      [MaxLength(50)]
      [Required]
      public string nombreDepart {get;set;}
      //Lista de paisdepartamentos
      public List<Pais_Departamento> paisDepartamento{get;set;}
      public List<Ciudad_Departamento> ciudadDepartamento{get;set;}

      

    }
}