using CRUDLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDLivros.Data
{
    public class LivrosContext:DbContext
    {
        public LivrosContext(DbContextOptions<LivrosContext> options):base(options)
        {

        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }

    }
}
