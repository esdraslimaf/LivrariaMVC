namespace CRUDLivros.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<LivroModel>? Livros { get; set; }
    }
}
