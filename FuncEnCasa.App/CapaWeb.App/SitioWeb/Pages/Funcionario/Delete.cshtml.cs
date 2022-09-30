using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FuncEnCasa.App.Persistencia;
using FuncEnCasa.App.Dominio;

namespace SitioWeb.Pages_Funcionario
{
    public class DeleteModel : PageModel
    {
        private IRepositorioFuncionario _repoFuncionario;

        [BindProperty]
        public Funcionario funcionario {get;set;}

        public DeleteModel()
        {
            _repoFuncionario= new RepositorioFuncionario(new FuncEnCasa.App.Persistencia.AppContext());
        }

        public void OnGet(int id)
        {
            funcionario=_repoFuncionario.ObtenerId(id);
        }
        public IActionResult OnPost()
        {
            _repoFuncionario.Eliminar(funcionario._Id);
            return RedirectToPage("/Index");
        }
    }
}
