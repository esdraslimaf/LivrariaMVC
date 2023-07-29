using CRUDLivros.Data;
using CRUDLivros.Models;
using CRUDLivros.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRUDLivros.Repository
{
    public class LivroRepository:ILivroRepository
    {
        private readonly LivrosContext _db;
        public LivroRepository(LivrosContext db)
        {
            _db = db;
        }

        public void AddLivro(LivroModel Livro) {
            _db.Livros.Add(Livro);
            _db.SaveChanges();
        }

        public List<LivroModel> GetLivros() {
            List<LivroModel> livros = _db.Livros.Include(a => a.Autor).ToList();
            return livros;
        }
       
        public void ExcluirLivro(int id)
        {
            _db.Remove(_db.Livros.Find(id));
            _db.SaveChanges();
        }


    }
}
