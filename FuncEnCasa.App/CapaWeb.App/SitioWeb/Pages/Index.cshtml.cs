using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using FuncEnCasa.App.Dominio;
using FuncEnCasa.App.Persistencia;

namespace SitioWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Funcionario> funcionarios{get;set;}
        private IRepositorioFuncionario _repoFuncionario;
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _repoFuncionario= new RepositorioFuncionario(new FuncEnCasa.App.Persistencia.AppContext()); 
        }

        public void OnGet(int id)
        {
            funcionarios= _repoFuncionario.ObtenerTodos();
        }

        
    }
}
