using System.ComponentModel.DataAnnotations;

namespace SiteCartinhasDoPapaiNoel.Models
{
    public class Cartinha
    {
        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string NomeDaCrianca { get; set; }

        [Required]
        public Endereco Endereco { get; set; }

        [Required]
        [Range(1, 15, ErrorMessage = "A idade da criança deve estar entre 1 e 15 anos.")]
        public int Idade { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "O texto da carta não pode ter mais de 500 caracteres.")]
        public string TextoDaCarta { get; set; }
    }
}
