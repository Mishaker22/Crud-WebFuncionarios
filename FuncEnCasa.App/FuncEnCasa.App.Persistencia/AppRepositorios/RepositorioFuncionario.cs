using System.Collections.Generic;
using FuncEnCasa.App.Dominio;
using System.Linq;

namespace FuncEnCasa.App.Persistencia
{
    public class RepositorioFuncionario : IRepositorioFuncionario
    {
        private readonly AppContext _appContext;

        public RepositorioFuncionario(AppContext contexto)
        {
            _appContext=contexto;
        }
        Funcionario IRepositorioFuncionario.Agregar(Funcionario funcNuevo)
        {
            var funcA=_appContext.Funcionarios.Add(funcNuevo);
            _appContext.SaveChanges();
            return funcA.Entity;
        }
        Funcionario IRepositorioFuncionario.Modificar(Funcionario funcActualizar)
        {
            var funcM=_appContext.Funcionarios.FirstOrDefault(f => f._Id==funcActualizar._Id);
            if(funcM!=null)
            {
                //funcM.usuarioId=funcActualizar.usuarioId;
                funcM.nombre=funcActualizar.nombre;
                funcM.apellido=funcActualizar.apellido;
                //funcM.correoId=funcActualizar.correoId;
                //funcM.telefonoId=funcActualizar.telefonoId;
                //funcM.tipoSanguineo=funcActualizar.tipoSanguineo;
                //funcM.fechaNacimiento=funcActualizar.fechaNacimiento;
                //funcM.genero=funcActualizar.genero;
                //funcM.ciudadBId=funcActualizar.ciudadBId;
                //funcM.direccionId=funcActualizar.direccionId;
               // funcM.sucursalId=funcActualizar.sucursalId;
                _appContext.SaveChanges();
            }
            return funcM;
        }
        void IRepositorioFuncionario.Eliminar(int id)
        {
            var funcB=_appContext.Funcionarios.FirstOrDefault(f => f._Id==id);
            if (funcB !=null)
            {
                _appContext.Funcionarios.Remove(funcB);
                _appContext.SaveChanges();
            }
        }
        Funcionario IRepositorioFuncionario.ObtenerId(int id)
        {
            return _appContext.Funcionarios.Where(f => f._Id==id).Select(f => new Funcionario
            {
                _Id=f._Id,
                idTipoDocumento=f.idTipoDocumento,
                usuarioId=f.usuarioId,
                nombre=f.nombre,
                apellido=f.apellido,
                genero=f.genero,
                tipoSanguineo=f.tipoSanguineo,
                fechaNacimiento=f.fechaNacimiento,
                ciudadId=f.ciudadId,
                direccionId=f.direccionId,
                sucursalId=f.sucursalId,
                telefonoId=f.telefonoId,
                idTipoContactoCorreo=f.idTipoContactoCorreo,
                correoId=f.correoId,
                correo=f.correo,
                idTipoContactoTelefono=f.idTipoContactoTelefono,
                telefono=f.telefono,
                ciudad=f.ciudad,
                direccion=f.direccion,
                sucursal=f.sucursal
            }).FirstOrDefault();
        }
       
        IEnumerable<Funcionario> IRepositorioFuncionario.ObtenerTodos()
        {
            return _appContext.Funcionarios.Select(f => new Funcionario
            {
                _Id=f._Id,
                idTipoDocumento=f.idTipoDocumento,
                usuarioId=f.usuarioId,
                nombre=f.nombre,
                apellido=f.apellido,
                genero=f.genero,
                tipoSanguineo=f.tipoSanguineo,
                fechaNacimiento=f.fechaNacimiento,
                ciudadId=f.ciudadId,
                direccionId=f.direccionId,
                sucursalId=f.sucursalId,
                telefonoId=f.telefonoId,
                idTipoContactoCorreo=f.idTipoContactoCorreo,
                correoId=f.correoId,
                correo=f.correo,
                idTipoContactoTelefono=f.idTipoContactoTelefono,
                telefono=f.telefono,
                ciudad=f.ciudad,
                direccion=f.direccion,
                sucursal=f.sucursal
            }).ToList();
        }
        
    }
}