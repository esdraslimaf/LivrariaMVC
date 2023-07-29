using System.ComponentModel.DataAnnotations;

namespace CRUDLivros.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O ID de um autor existente é obrigatório!")]
        [Range(1, int.MaxValue, ErrorMessage = "O campo AutorId deve ser um número maior que zero.")]
        public int AutorId { get; set; }
        public AutorModel? Autor { get; set; } = null!;

        [StringLength(100, ErrorMessage ="O máximo de caracteres para Título é 100!")]
        public string? Titulo { get; set; }
        public DateTime? DataPublicacao { get; set; }
        [StringLength(100, ErrorMessage = "O máximo de caracteres para Editora é 100!")]
        public string? Editora { get; set; }
    }
}
