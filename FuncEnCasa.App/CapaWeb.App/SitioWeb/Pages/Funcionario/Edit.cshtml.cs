using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FuncEnCasa.App.Dominio;
using FuncEnCasa.App.Persistencia;

namespace SitioWeb.Pages_Funcionario
{
    public class EditModel : PageModel
    {
        private IRepositorioFuncionario _repoFuncionario;

        [BindProperty]
        public Funcionario funcionario {get;set;}

        public EditModel()
        {
            _repoFuncionario= new RepositorioFuncionario(new FuncEnCasa.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int id)
        {
            funcionario=_repoFuncionario.ObtenerId(id);
            if (funcionario==null)
            {
                return RedirectToPage("/Index");
            }else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Funcionario funcionario)
        {
            _repoFuncionario.Modificar(funcionario);
            return RedirectToPage("/Index");
        }
    }
}
