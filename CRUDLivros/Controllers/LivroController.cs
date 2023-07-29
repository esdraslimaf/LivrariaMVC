using CRUDLivros.Models;
using CRUDLivros.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDLivros.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroRepository _repo;
        private readonly IAutorRepository _repoAutor;
        public LivroController(ILivroRepository repo, IAutorRepository repoAutor)
        {
            _repo = repo;
            _repoAutor = repoAutor;
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
            if (!ModelState.IsValid) {
                return View("AdicionarLivro");
            }
            var autor = _repoAutor.BuscarAutorId(Livro.AutorId);
            if (autor == null)
            {
                ModelState.AddModelError("AutorId", "Informe um id de autor existente!");
                return View("AdicionarLivro");
            }
            
                _repo.AddLivro(Livro);
                return RedirectToAction("Index");
           

        }
    }
}
