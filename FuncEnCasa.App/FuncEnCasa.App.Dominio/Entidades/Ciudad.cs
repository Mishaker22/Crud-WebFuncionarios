using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FuncEnCasa.App.Dominio

{
    public class Ciudad
    {
      [Key] 
      [Column("IdCiudad")]
      public int _Id{get;set;}
      [MaxLength(50)]
      [Required]
      public string nombreCiudad {get;set;}
      //listas
      public List<Ciudad_Departamento> ciudadDepartamento{get;set;}// de Departamento Ciudad
      public List<Ciudad_BarrioZonaLocalidad> ciudadBarrioZonaLocalidad{get;set;}//de CiudadBarrioZonaSector
      public List<Sucursal> sucursal{get;set;}//de Sucursal
      public List<Funcionario> funcionario{get;set;}// de funcionarios
    }
}