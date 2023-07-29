using CRUDLivros.Models;
using CRUDLivros.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDLivros.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroRepository _repo;
        public LivroController(ILivroRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {   
            return View(_repo.GetLivros());
        }

        public IActionResult AdicionarLivro()
        {
            return View();
        }

        
        public IActionResult ExcluirLivro(int id)
        {
            _repo.ExcluirLivro(id);
            return RedirectToAction("Index");
        }

        public IActionResult AddLivro(LivroModel Livro)
        {
            _repo.AddLivro(Livro);
            return RedirectToAction("Index");
        }
    }
}
