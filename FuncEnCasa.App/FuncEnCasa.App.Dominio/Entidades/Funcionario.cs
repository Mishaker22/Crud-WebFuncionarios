using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FuncEnCasa.App.Dominio

{
    public class Funcionario
    {
        [Key]
        [Column("IdFuncionario")]
        public int _Id{get;set;}

        [Required]
        public TipoDocumento idTipoDocumento{get;set;}

        public int? usuarioId{get;set;}
        public Usuario usuario {get;set;}

        [Required]
        [StringLength(20, MinimumLength=2)]
        public string nombre{get;set;}

        [Required]
        [StringLength(20, MinimumLength=2)]
        public string apellido {get;set;}
        
        [Required]
        public TipoContacto idTipoContactoCorreo{get;set;}

        
        public int? correoId{get;set;}
        public Correo correo{get;set;}

        [Required]
        public TipoContacto idTipoContactoTelefono{get;set;}

       
        public int? telefonoId{get;set;}
        public Telefono telefono{get;set;}

        [Required]
        public TipoSanguineo tipoSanguineo{get;set;}
        [Required]
        public DateTime fechaNacimiento{get;set;}
        [Required]
        public Genero genero{get;set;}

        public int? ciudadId{get;set;}
        public Ciudad ciudad {get;set;}

        public int? direccionId {get;set;}
        public Direccion direccion{get;set;}

        public int? sucursalId{get;set;}
        public Sucursal sucursal {get;set;}

        
    }
}