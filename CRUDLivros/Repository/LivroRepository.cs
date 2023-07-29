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
            LivroModel livro = _db.Livros.Find(id);
            _db.Remove(livro);
            _db.SaveChanges();
        }

        public LivroModel BuscarPorId(int id)
        {
           return _db.Livros.FirstOrDefault(l=>l.Id==id);
        }

        public void ConfirmarEdicao(LivroModel livro)
        {
            LivroModel livrodb = _db.Livros.Find(livro.Id);
            livrodb.Autor = livro.Autor;
            livrodb.AutorId = livro.AutorId;
            livrodb.Editora = livro.Editora;
            livrodb.DataPublicacao = livro.DataPublicacao;
            livrodb.Titulo = livro.Titulo;
            _db.Livros.Update(livrodb);
            _db.SaveChanges();
        }


    }
}
