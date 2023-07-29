using CRUDLivros.Models;
using CRUDLivros.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDLivros.Controllers
{
    public class AutorController : Controller
    {
        private readonly IAutorRepository _repo;

        public AutorController(IAutorRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAutores());
        }

        public IActionResult AdicionarAutor()
        {
            return View();
        }

        public IActionResult EditarAutor(int id)
        {
            AutorModel autor = _repo.BuscarAutorId(id);
            return View(autor); 
        }



        /* [HttpGet]
        public IActionResult GetAutores()
        {
            return Ok(_repo.GetAutores());
        } */


        public IActionResult AddAutor(AutorModel Autor)
        {
            if (!ModelState.IsValid)
            {
                // Se o modelo não for válido, retorne a view com os erros de validação.
                return View("AdicionarAutor");
            }
            _repo.AddAutor(Autor);
            return RedirectToAction("Index");
        }
        
       

        public IActionResult ExcluirAutor(int id)
        {
            _repo.ExcluirAutor(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ConfirmaEdicaoAutor(AutorModel Autor)
        {
            _repo.ConfirmaEdicaoAutor(Autor);
            return RedirectToAction("Index");
        }


    }
}
