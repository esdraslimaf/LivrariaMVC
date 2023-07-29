using System.ComponentModel.DataAnnotations;

namespace CRUDLivros.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public int AutorId { get; set; }
        public AutorModel? Autor { get; set; } = null!;

        [MaxLength(100)]
        public string? Titulo { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public string? Editora { get; set; }
    }
}
