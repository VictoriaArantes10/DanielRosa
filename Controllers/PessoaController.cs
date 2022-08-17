using Cadastro.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Controllers
{
    public class PessoaController : Controller
    {
        private readonly AppCad _appCad;

        public PessoaController(AppCad appCad)
        {
            _appCad = appCad;
        }

        public IActionResult Index() 
        {
            var allPessoas = _appCad.Pessoa.ToList();
            return View(allPessoas);
        }
    }
}
