using System.ComponentModel.DataAnnotations;

namespace CRUDLivros.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do autor é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome do autor deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; }
        public List<LivroModel>? Livros { get; set; }
    }
}
