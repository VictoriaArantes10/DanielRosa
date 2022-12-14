using System.ComponentModel.DataAnnotations;

namespace Cadastro.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Endereco { get; set; }
    }
}
