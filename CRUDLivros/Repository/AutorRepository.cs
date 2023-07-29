using CRUDLivros.Data;
using CRUDLivros.Models;
using CRUDLivros.Repository.Interfaces;

namespace CRUDLivros.Repository
{
    public class AutorRepository : IAutorRepository
    {
        private readonly LivrosContext _db;

        public AutorRepository(LivrosContext db) { 
            _db = db;
        }

        public void AddAutor(AutorModel Autor)
        {
            _db.Autores.Add(Autor);
            _db.SaveChanges();
        }

        public AutorModel BuscarAutorId(int id)
        {
            AutorModel Autor = _db.Autores.FirstOrDefault(a => a.Id == id);
           // if (Autor == null) { throw new Exception("O autor não existe!"); }
           // else
            //{
                return Autor;
            //}
        }

        public AutorModel ConfirmaEdicaoAutor(AutorModel autor)
        {
           AutorModel Autor = BuscarAutorId(autor.Id);
            if (Autor == null) throw new Exception("Autor não existe!");
            
            Autor.Nome = autor.Nome;
            _db.Autores.Update(Autor);
            _db.SaveChanges();
            return autor; 
        }

        public void ExcluirAutor(int id)
        {
            _db.Autores.Remove(_db.Autores.Find(id));
            _db.SaveChanges();
        }

        public List<AutorModel> GetAutores()
        {
            return _db.Autores.ToList();
        }
    }
}
