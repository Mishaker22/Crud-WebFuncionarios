using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FuncEnCasa.App.Dominio

{
    public class Ciudad_Departamento
    {
      [Key] 
      [Column("IdCiudadDepartamento")]
      public int _Id{get;set;}

      public int? ciudadId {get;set;}
      public Ciudad ciudad{get;set;}

      public int? departamentoId{get;set;}
      public Departamento departamento{get;set;}

    }
}