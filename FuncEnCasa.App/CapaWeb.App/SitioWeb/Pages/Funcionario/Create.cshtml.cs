using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using FuncEnCasa.App.Dominio;
using FuncEnCasa.App.Persistencia;

namespace SitioWeb.Pages_Funcionario
{
    public class CreateModel : PageModel
    {
        private IRepositorioFuncionario _repoFuncionario{get;set;}
        private IRepositorioCiudad _repoCiudad{get;set;}
        private IRepositorioSucursal _repoSucursal{get;set;}

        [BindProperty]
        public Funcionario funcionario{get;set;}
        public IEnumerable<Ciudad> ciudades{get;set;}
        public IEnumerable<Sucursal> sucursales{get;set;}


        public CreateModel()
        {
            _repoFuncionario= new RepositorioFuncionario(new FuncEnCasa.App.Persistencia.AppContext());
            _repoSucursal= new RepositorioSucursal(new FuncEnCasa.App.Persistencia.AppContext());
            _repoCiudad= new RepositorioCiudad(new FuncEnCasa.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
            sucursales=_repoSucursal.ObtenerTodos();
            ciudades=_repoCiudad.ObtenerTodos();
        }
        public IActionResult OnPost(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
               _repoFuncionario.Agregar(funcionario);
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
            
        }
    }
}
