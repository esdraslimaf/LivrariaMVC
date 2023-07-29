using CRUDLivros.Models;

namespace CRUDLivros.Repository.Interfaces
{
    public interface IAutorRepository
    {
        void AddAutor(AutorModel Autor);
        List<AutorModel> GetAutores();
        void ExcluirAutor(int id);
        AutorModel BuscarAutorId(int id);
        AutorModel ConfirmaEdicaoAutor(AutorModel autor);

    }
}
