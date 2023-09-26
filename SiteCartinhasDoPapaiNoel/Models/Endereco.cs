using System.ComponentModel.DataAnnotations;

namespace SiteCartinhasDoPapaiNoel.Models
{
    public class Endereco
    {
        [Required]
        public string Rua { get; set; }

        [Required]
        public string Numero { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }
    }
}
